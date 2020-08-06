using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Xl.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class OmHelper
    {
        protected static bool Add<TModel>(TModel model) where TModel : class, new()
        {
            Sql sql = SqlBuilder.Insert(model);
            return SqlHelper.ExecuteNonQuery(sql.Commandtext) > 0;
        }
        protected static bool Update<TModel>(TModel model, Expression<Func<TModel, bool>> exp) where TModel : class, new()
        {
            Sql sql = SqlBuilder.Update(model, exp);
            return SqlHelper.ExecuteNonQuery(sql.Commandtext) > 0;
        }
        protected static bool Delete<TModel>(Expression<Func<TModel, bool>> exp) where TModel : class, new()
        {
            Sql sql = SqlBuilder.Delete(exp);
            return SqlHelper.ExecuteNonQuery(sql.Commandtext) > 0;
        }


        protected static TColunmType GetMax<TModel, TColunmType>(Expression<Func<TModel, TColunmType>> exp) where TModel : class, new()
        {

            Sql sql = SqlBuilder.GetMax(exp);
            var dt = SqlHelper.ExecuteDataTable(sql.Commandtext);
            if (dt != null && dt.Rows.Count > 0)
            {
                return (TColunmType)ReflectionHelper.ChangeValue(typeof(TColunmType), dt.Rows[0][0]);
            }
            return default(TColunmType);
        }

        protected static TColunmType GetMin<TModel, TColunmType>(Expression<Func<TModel, TColunmType>> exp) where TModel : class, new()
        {

            Sql sql = SqlBuilder.GetMax(exp);
            var dt = SqlHelper.ExecuteDataTable(sql.Commandtext);
            if (dt != null && dt.Rows.Count > 0)
            {
                return (TColunmType)ReflectionHelper.ChangeValue(typeof(TColunmType), dt.Rows[0][0]);
            }
            return default(TColunmType);

        }

        protected static TModel GetFirst<TModel>(QueryExpression<TModel> query) where TModel : class, new()
        {
            Sql sql = SqlBuilder.GetFirst<TModel>(query);
            return SqlHelper.ExecuteDataTable(sql.Commandtext)?.ToList<TModel>()?.FirstOrDefault();

        }
        protected static TModel GetFirst<TModel>(Expression<Func<TModel, bool>> exp) where TModel : class, new()
        {
            Sql sql = SqlBuilder.GetFirst(exp);
            return SqlHelper.ExecuteDataTable(sql.Commandtext)?.ToList<TModel>()?.FirstOrDefault();
        }
        /// <summary>
        /// 一表查询
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="exp"></param>
        /// <returns></returns>
        protected static List<TModel> GetList<TModel>(Expression<Func<TModel, bool>> exp) where TModel : class, new()
        {
            Sql sql = SqlBuilder.GetList(exp);
            return SqlHelper.ExecuteDataTable(sql.Commandtext)?.ToList<TModel>();
        }

        /// <summary>
        /// 一表查询
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        public static List<TModel> GetList<TModel>(QueryExpression<TModel> query) where TModel : class, new()
        {
            Sql sql = SqlBuilder.GetList<TModel>(query);
            return SqlHelper.ExecuteDataTable(sql.Commandtext)?.ToList<TModel>();
        }
        ///// <summary>
        ///// 二表查询
        ///// </summary>
        ///// <typeparam name="TModel1"></typeparam>
        ///// <typeparam name="TModel2"></typeparam>
        ///// <param name="sql"></param>
        ///// <returns></returns>
        //public static Sql GetList<TModel1, TModel2, QueryParams>(Sql sql)
        //{
        //    Sql sql = SqlBuilder.GetList(query);
        //    return SqlHelper.ExecuteDataTable(sql.Commandtext)?.ToList<TModel>()?.FirstOrDefault();

        //}
        ///// <summary>
        ///// 三表查询
        ///// </summary>
        ///// <typeparam name="TModel1"></typeparam>
        ///// <typeparam name="TModel2"></typeparam>
        ///// <typeparam name="TModel3"></typeparam>
        ///// <typeparam name="TResult"></typeparam>
        ///// <param name="exp"></param>
        ///// <returns></returns>
        //public static Sql GetList<TModel1, TModel2, TModel3, TResult>(Expression<Func<TModel1, TModel2, TModel3, object[]>> exp)
        //{
        //    SqlBuilder.GetList();

        //}


    }
    public class WirteOmHelper : OmHelper
    {


    }

    public class ReadOmHelper : OmHelper
    {
        private static List<ConnectionModel> GetConnections()
        {

            return new List<ConnectionModel>();
        }

        public static int defaultValue = 0;
        //询轮策略
        public static string GetPollingPolicy()
        {
            List<ConnectionModel> connectionModels = GetConnections();
            if (connectionModels.Count > 0)
            {
                var index = (defaultValue++) % connectionModels.Count;
                return connectionModels[index].ConnectionStr;
            }
            return string.Empty;
        }
        //权重策略
        public static string GetWeightPolicy()
        {
            List<string> connectionList = new List<string>();
            List<ConnectionModel> connectionModels = GetConnections();

            if (connectionModels.Sum(c => c.Weight) == 100)
            {
                throw new Exception("权重配置总和不是100");
            }
            foreach (var connectionModel in connectionModels)
            {
                for (int i = 0; i < connectionModel.Weight; i++)
                {
                    connectionList.Add(connectionModel.ConnectionStr);
                }
            }
            var index = new Random(defaultValue++).Next(0, connectionList.Count);
            return connectionList[index];

        }
    }
}
