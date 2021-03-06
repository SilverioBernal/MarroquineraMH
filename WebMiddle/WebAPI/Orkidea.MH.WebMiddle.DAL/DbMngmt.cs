﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orkidea.MH.WebMiddle.Entities;
using Orkidea.Framework.Data;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Orkidea.MH.WebMiddle.DAL
{
    public static class DbMngmt<T> where T : class
    {
        public static IList<T> GetList()
        {
            using (var context = new MHERPEntities())
            {
                DataEF<T> dataEF = new DataEF<T>(context);
                return dataEF.GetList();
            }
        }

        public static IList<T> GetList(Expression<Func<T, bool>> where)
        {
            using (DbContext context = new MHERPEntities())
            {
                DataEF<T> dataEF = new DataEF<T>(context);
                return dataEF.GetList(where);
            }
        }

        public static T GetSingle(Expression<Func<T, bool>> where)
        {
            using (DbContext context = new MHERPEntities())
            {
                DataEF<T> dataEF = new DataEF<T>(context);
                return dataEF.GetSingle(where);
            }
        }        

        public static T Add(T item)
        {
            using (var context = new MHERPEntities())
            {
                DataEF<T> dataEF = new DataEF<T>(context);
                dataEF.Add(item);

                return item;
            }
        }

        public static void Add(T[] item)
        {
            using (var context = new MHERPEntities())
            {
                DataEF<T> dataEF = new DataEF<T>(context);
                dataEF.Add(item);
            }
        }

        public static void Update(T item)
        {
            using (var context = new MHERPEntities())
            {
                DataEF<T> dataEF = new DataEF<T>(context);
                dataEF.Update(item);
            }
        }

        public static void Update(T[] item)
        {
            using (var context = new MHERPEntities())
            {
                DataEF<T> dataEF = new DataEF<T>(context);
                dataEF.Update(item);
            }
        }

        public static void Remove(T item)
        {
            using (var context = new MHERPEntities())
            {
                DataEF<T> dataEF = new DataEF<T>(context);
                dataEF.Remove(item);
            }
        }

        public static void Remove(T[] item)
        {
            using (var context = new MHERPEntities())
            {
                DataEF<T> dataEF = new DataEF<T>(context);
                dataEF.Remove(item);
            }
        }

        public static IList<T> executeSqlQueryToList(string sql)
        {
            IList<T> list;

            using (var context = new MHERPEntities())
            {
                context.Database.CommandTimeout = 0;
                list = context.Database.SqlQuery<T>(sql).ToList();
            }

            return list;
        }

        public static T executeSqlQuerySingle(string sql)
        {
            T genericObject;

            using (var context = new MHERPEntities())
            {
                context.Database.CommandTimeout = 9000;
                genericObject = context.Database.SqlQuery<T>(sql).FirstOrDefault();
            }

            return genericObject;
        }

        public static int executeSqlQueryNonQuery(string sql)
        {           
            using (var context = new MHERPEntities())
            {
                context.Database.CommandTimeout = 9000;
                return context.Database.ExecuteSqlCommand(sql);
            }            
        }
    }
}
