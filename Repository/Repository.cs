using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace New_OnlineTaxibooking.Repository
{
    public interface Repository<tbl_Entity> where tbl_Entity : class
    {
        IEnumerable<tbl_Entity> GetAllRecords();
        IQueryable<tbl_Entity> GetAllRecordsIQueryable();
        int GetAllRecordCount();
        void Add(tbl_Entity entity);
        void Update(tbl_Entity entity);
        void UpdateByWhereClause(Expression<Func<tbl_Entity, bool>> wherePredict, Action<tbl_Entity> ForEachPredict);
        tbl_Entity GetFirstorDefault(int recordId);
        void Remove(tbl_Entity entity);
        void RemovebyWhereClause(Expression<Func<tbl_Entity, bool>> wherePredict);
        void RemoveRangeByWhereClause(Expression<Func< tbl_Entity, bool>> wherePredict);
        void InactiveAndDeleteMarkByWhereClause(Expression<Func<tbl_Entity,bool>> wherePredict,Action<tbl_Entity> ForEachPredict);
        tbl_Entity GetFirstorDefaultByParameter(Expression<Func<tbl_Entity, bool>> wherePredic);
        IEnumerable<tbl_Entity> GetListParmeter(Expression<Func<tbl_Entity, bool>> wherePredic);
        IEnumerable<tbl_Entity> GetResultBySqlprocedure(string query,params object[] parameters);

        IEnumerable<tbl_Entity>GetRecordsToShow(int PageNo,int PageSize ,int CurrentPage,Expression<Func<tbl_Entity,bool>>wherePredict,Expression<Func<tbl_Entity,int>>orderByPredict);

    }
}