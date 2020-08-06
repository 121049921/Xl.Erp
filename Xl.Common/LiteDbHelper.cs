using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using LiteQueue;
namespace Xl.Common
{

    public class QueryExtension
    {
        public Query Contains<TModel, Tkey>(Expression<Func<TModel, Tkey>> exp, string value)
        {
            if (exp != null)
            {

                MemberExpression memberExpression = exp.Body as MemberExpression;
                string filed = memberExpression.Member.Name;
                return Query.Contains(filed, value);
            }
            return null;
        }

    }
    public class LiteDbHelper : Sinleton<LiteDbHelper>
    {
        private string connnect = "xialei.db";
        public int Insert<TModel>(TModel model)
        {
            using (var db = new LiteDatabase(connnect))
            {

                var col = db.GetCollection<TModel>();

                BsonValue bsonValue = col.Insert(model);
                var key = bsonValue.AsInt32;
                return key;
            }
        }


        public int InsertBulk<TModel>(List<TModel> model)
        {
            using (var db = new LiteDatabase(connnect))
            {
                //获取 customers 集合，如果没有会创建，相当于表
                var col = db.GetCollection<TModel>();

                BsonValue bsonValue = col.InsertBulk(model);
                return bsonValue.AsInt32;
            }

        }
        public List<TModel> Find<TModel>(Expression<Func<TModel, bool>> predicate, int skip = 0, int limit = int.MaxValue)
        {
            using (var db = new LiteDatabase(connnect))
            {
                var col = db.GetCollection<TModel>();
                return col.Find(predicate, skip, limit).ToList();

            }

        }
        public TModel FindOne<TModel>()
        {
            using (var db = new LiteDatabase(connnect))
            {
                var col = db.GetCollection<TModel>();
                return col.FindOne(it=>true);

            }

        }
        public List<TModel> FindAll<TModel>()
        {
            using (var db = new LiteDatabase(connnect))
            {
                var col = db.GetCollection<TModel>();
                return col.FindAll().ToList();

            }

        }
        /// <summary>
        ///分页
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="count"></param>
        /// <param name="query"></param>
        /// <param name="skip"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public List<TModel> Find<TModel>(out int count, Query query, int skip = 0, int limit = int.MaxValue)
        {
            count = 0;
            using (var db = new LiteDatabase(connnect))
            {
                var col = db.GetCollection<TModel>();
                if (query != null)
                {
                    count = col.Count(query);
                    if (count > 0)
                    {
                        var result = col.Find(query, skip, limit).ToList();
                        return result;
                    }
                }
                else
                {
                    count = col.Count(x => true);
                    var result = col.Find(x => true, skip, limit).ToList();
                    return result;
                }
            }
            return new List<TModel>();

        }

        public string Max<TModel, TKey>(Expression<Func<TModel, TKey>> property)
        {
            using (var db = new LiteDatabase(connnect))
            {
                var col = db.GetCollection<TModel>();
                BsonValue bsonValue = col.Max(property);
                return bsonValue.AsString;
            }

        }
        public string Max(Type modelType, string field)
        {
            using (var db = new LiteDatabase(connnect))
            {

                if (modelType==null||string.IsNullOrWhiteSpace(modelType.Name))
                {
                    return string.Empty;
                }

                var col = db.GetCollection(modelType.Name);

                var xx = col.Find(x => x.IsString, 0, 1);
                var xxx = xx.ToString();
                var inta = col.Count();
                BsonValue bsonValue = col.Max();
                var code = bsonValue.AsString;
                //BsonValue bsonValue = col.FindOne(x=>x.);
                //var x = bsonValue.ToString();
                // return bsonValue.AsString;
                return code;

            }

        }
        public TModel Update<TModel>(TModel model)
        {
            using (var db = new LiteDatabase(connnect))
            {
                var col = db.GetCollection<TModel>();
                BsonValue bsonValue = col.Update(model);
                return model;
            }

        }

        public int Delete<TModel>(Expression<Func<TModel, bool>> predicate)
        {
            using (var db = new LiteDatabase(connnect))
            {
                var col = db.GetCollection<TModel>();
                BsonValue bsonValue = col.Delete(predicate);
                return bsonValue.AsInt32;
            }

        }
    }


}
