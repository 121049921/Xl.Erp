using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Xl.Common;
using Xl.UIComponent.Properties;

namespace Xl.UIComponent
{


    public  partial class ListBaseForm : Xl.UIComponent.CommonBaseForm
    {



        //private SuperTabItem parentTabItem;

        /// <summary>
        /// 帮定的字段名称
        /// </summary>
        private List<BindGridColumn> bindGridColumns;

        /// <summary>
        /// 基类编辑窗体
        /// <![CDATA[用抽象类总报错]]>
        /// </summary>

        protected virtual Type EditBaseForm { get; set; }

        /// <summary>
        /// 编辑的Id
        /// </summary>
        protected virtual int Id { get; set; } = 0;
        /// <summary>
        /// 绑定到表格上实体对象类型
        /// </summary>

        protected virtual Type BindGridEntity { get; set; }




        public ListBaseForm()
        {
            InitializeComponent();
            this.listFormToolBar.AddClick += AddClick;
            this.listFormToolBar.EditClick += EditClick;
            this.listFormToolBar.DeleteClick += DeleteClick;
            this.listFormToolBar.CloseClick += CloseClick;
            this.listFormToolBar.SearchClick += SearchClick;
            this.listFormToolBar.AdvSearchClick += AdvSearchClick;
            this.pageToolBar.NextClick += PageToolBar_NextClick;
            this.pageToolBar.PrevClick += PageToolBar_PrevClick;
            this.pageToolBar.CmbPageSizeSelectedIndexChangedEvnet += PageToolBarCmbPageSizeSelectedIndexChanged;
           
        }



        private void ListBaseForm_Load(object sender, EventArgs e)
        {

            OnFormLoadBefor();
            OnFormLoad();
            OnFormLoadAfter();
            OnListEntityChange();
            BindGrid<object>(null, new PageabledEventArgs());
        }


        #region 加载窗体
        protected virtual void OnFormLoadBefor()
        {




        }
        protected virtual void OnFormLoad()
        {




        }
        protected virtual void OnFormLoadAfter()
        {




        }
        #endregion


        #region 注册事件

        protected virtual void AddClick(object sender, EventArgs e)
        {
            string editFormText = string.Empty;
            if (EditBaseForm != null)
            {
                if (sender is DevComponents.DotNetBar.ButtonItem)
                {
                    DevComponents.DotNetBar.ButtonItem button = sender as DevComponents.DotNetBar.ButtonItem;
                    editFormText = button.Text;
                }
                EditBaseForm editBaseForm = Activator.CreateInstance(EditBaseForm) as EditBaseForm;
                editBaseForm.Icon = Xl.UIComponent.Properties.Resources.Icon;
                editBaseForm.IsAdd = true;
                editBaseForm.Text = editFormText;
                editBaseForm.StartPosition = FormStartPosition.CenterParent;
                editBaseForm.ShowDialog();
            }
        }

        protected virtual void EditClick(object sender, EventArgs e)
        {
            string editFormText = string.Empty;
            if (EditBaseForm != null)
            {
                if (sender is DevComponents.DotNetBar.ButtonItem)
                {
                    DevComponents.DotNetBar.ButtonItem button = sender as DevComponents.DotNetBar.ButtonItem;
                    editFormText = button.Text;
                }
                if (Id <= 0)
                {
                    MessageBoxEx.Show("请选择一条数据");
                    return;
                }
                EditBaseForm editBaseForm = Activator.CreateInstance(EditBaseForm) as EditBaseForm;
                editBaseForm.IsAdd = false;
                editBaseForm.Id = Id;
                editBaseForm.Text = editFormText;
                editBaseForm.ShowDialog();
            }
        }
        protected virtual void DeleteClick(object sender, PageabledEventArgs e)
        {

           

        }



        protected virtual void CloseClick(object sender, EventArgs e)
        {

            this.TabMain.SelectedTab.Close();
            this.Close();

        }
        private void SearchClick(object sender, PageabledEventArgs arg)
        {
            BindGrid<object>(null, arg);
        }
        private void AdvSearchClick(object sender, QueryParameterEventArgs arg)
        {
            AdvSearch();
        }

        protected virtual void AdvSearch()
        {

            MessageBox.Show("自定义界面实现");


        }
        #endregion



        #region 上一页,下一页
        [DebuggerHidden]
        private void PageToolBar_PrevClick(object sender, PageabledEventArgs arg)
        {
            BindGrid<object>(null, arg);
        }


        private void PageToolBar_NextClick(object sender, PageabledEventArgs arg)
        {
            BindGrid<object>(null, arg);
        }

        #endregion

        #region  索引数
        private void PageToolBarCmbPageSizeSelectedIndexChanged(object sender, PageabledEventArgs arg)
        {
            BindGrid<object>(null, arg);
        }

        #endregion

        #region 将实体对象变为可绑定的
        private void OnListEntityChange()
        {
            if (BindGridEntity != null)
            {
                var ps = BindGridEntity.GetProperties();
                bindGridColumns = new List<BindGridColumn>();

                foreach (var p in ps)
                {
                    var attrs = p.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                    string headerText = string.Empty;
                    if (attrs.Any())
                    {
                        DisplayNameAttribute displayNameAttribute = attrs.First() as DisplayNameAttribute;
                        headerText = displayNameAttribute.DisplayName;
                    }
                    else
                    {
                        headerText = p.Name;
                    }
                    var bindGridColumn = new BindGridColumn()
                    {
                        HeaderText = headerText,
                        PropertieName = p.Name,
                        PropertieType = p.PropertyType
                    };
                    bindGridColumns.Add(bindGridColumn);
                }
            }

        }
        #endregion

        #region 绑定到grid表格
        private List<GridColumn> gridColumns = new List<GridColumn>();
        protected virtual void BindGrid<T>(List<T> source, PageabledEventArgs args)
        {
            //这种控件绑定有些耗性能,可能换dataGrid控件,dataGrid.DataSoucre 绑定性能高很多
            gridColumns.Clear();
            superGrid.PrimaryGrid.Columns.Clear();
            superGrid.PrimaryGrid.Rows.Clear();
            if (bindGridColumns != null && bindGridColumns.Count > 0)
            {
                foreach (var column in bindGridColumns)
                {
                    GridColumn gColumn = new GridColumn()
                    {
                        Name = column.PropertieName,
                        HeaderText = column.HeaderText,
                        DataPropertyName = column.PropertieName,
                        DataType = column.PropertieType
                    };
                    gridColumns.Add(gColumn);
                    superGrid.PrimaryGrid.Columns.Add(gColumn);
                }


                if (source != null && source.Count > 0)
                {
                    T t = source.FirstOrDefault<T>();
                    var properties = t.GetType().GetProperties().ToList();
                    foreach (var item in source)
                    {
                        GridRow dr = superGrid.PrimaryGrid.NewRow();
                        for (int i = 0; i < gridColumns.Count; i++)
                        {
                            GridColumn gColumn = gridColumns[i];
                            var value = properties.FirstOrDefault(x => x.Name.Equals(gColumn.Name)).GetValue(item);
                            //处理bool 是与否
                            if (gColumn.DataType.Equals(typeof(bool)))
                            {
                                if (Convert.ToBoolean(value))
                                {
                                    dr[gColumn].Value = "是";
                                }
                                else
                                {
                                    dr[gColumn].Value = "否";
                                }
                            }
                            else if (gColumn.DataType.IsEnum)
                            {
                                dr[gColumn].Value = EnumHelper.GetDescription(gColumn.DataType, value.ToString());
                            }
                            else
                            {
                                dr[gColumn].Value = value;
                            }
                        }

                        superGrid.PrimaryGrid.Rows.Add(dr);
                    }
                }

                //控制表格只能选中单行
                superGrid.PrimaryGrid.MultiSelect = true;
                superGrid.PrimaryGrid.InitialSelection = RelativeSelection.Row;
                //只能选中一个单元格，而不是一行单元格
                superGrid.PrimaryGrid.SelectionGranularity = SelectionGranularity.Row;

                superGrid.PrimaryGrid.ShowRowHeaders = true;
                superGrid.PrimaryGrid.ShowRowGridIndex = true;
                superGrid.PrimaryGrid.RowHeaderIndexOffset = 1;

                superGrid.PrimaryGrid.Filter.Visible = true;
                superGrid.PrimaryGrid.EnableFiltering = true;
                superGrid.PrimaryGrid.EnableColumnFiltering = true;

                superGrid.PrimaryGrid.ColumnAutoSizeMode = ColumnAutoSizeMode.AllCells;

                superGrid.PrimaryGrid.ColumnHeader.AllowSelection = true;
                superGrid.PrimaryGrid.GroupByRow.Visible = false;

                GridPanel panel = superGrid.PrimaryGrid;
                panel.AutoExpandSetGroup = true;
                superGrid.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
                this.pageToolBar.ChangePageCount(args.TotalCount);
            }

        }



        #endregion

        #region 获了选中行

        protected virtual List<int> GetSelectRows()
        {
            var ids = new List<int>();
            //获取选中单元整行数据
            SelectedElementCollection selectedRows = this.superGrid.PrimaryGrid.GetSelectedRows();
            foreach (var selectedRow in selectedRows)
            {
                try
                {
                    GridRow gridRow = selectedRow as GridRow;
                    var id = gridRow.Cells["Id"].Value;
                    this.Id = Convert.ToInt32(id);
                    ids.Add(Id);
                }
                catch (Exception ex)
                {
                    throw new Exception("没有绑定Id,主键列,请修改" + ex.ToString());
                }
            }
            return ids;
        }


        #endregion

        #region 选中行事件

        private void superGrid_Click(object sender, EventArgs e)
        {
            GetSelectRows();

        }

        #endregion
    }
}
