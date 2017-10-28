/**  版本信息模板在安装目录下，可自行修改。
* A_994.cs
*
* 功 能： N/A
* 类 名： A_994
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/25 14:44:27   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// A_994
	/// </summary>
	public partial class A_Table
	{
		private readonly Maticsoft.DAL.A_Table dal=new Maticsoft.DAL.A_Table();
		public A_Table()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId(string TableName)
		{
            return dal.GetMaxId(TableName);
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool Exists(DateTime DataTime, int PointID, int GeneID, int DataType, string TableName)
		{
			return dal.Exists(DataTime,PointID,GeneID,DataType, TableName);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.A_Table model,string TableName)
		{
			return dal.Add(model, TableName);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.A_Table model,string TableName)
		{
			return dal.Update(model, TableName);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
        public bool Delete(DateTime DataTime, int PointID, int GeneID, int DataType, string TableName)
		{
			
			return dal.Delete(DataTime,PointID,GeneID,DataType, TableName);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
        public Maticsoft.Model.A_Table GetModel(DateTime DataTime, int PointID, int GeneID, int DataType, string TableName)
		{
			
			return dal.GetModel(DataTime,PointID,GeneID,DataType, TableName);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        public Maticsoft.Model.A_Table GetModelByCache(DateTime DataTime, int PointID, int GeneID, int DataType, string TableName)
		{
			
			string CacheKey = "A_TableModel-" + DataTime+PointID+GeneID+DataType;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(DataTime,PointID,GeneID,DataType,TableName);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.A_Table)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
        public DataSet GetList(string strWhere, string TableName)
		{
			return dal.GetList(strWhere, TableName);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder, string TableName)
		{
			return dal.GetList(Top,strWhere,filedOrder, TableName);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
        public List<Maticsoft.Model.A_Table> GetModelList(string strWhere, string TableName)
		{
			DataSet ds = dal.GetList(strWhere, TableName);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.A_Table> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.A_Table> modelList = new List<Maticsoft.Model.A_Table>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.A_Table model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList(string TableName)
		{
			return GetList("", TableName);
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
        public int GetRecordCount(string strWhere, string TableName)
		{
			return dal.GetRecordCount(strWhere, TableName);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex, string TableName)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex, TableName);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

