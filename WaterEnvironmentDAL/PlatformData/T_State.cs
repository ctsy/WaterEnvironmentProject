﻿/**  版本信息模板在安装目录下，可自行修改。
* T_State.cs
*
* 功 能： N/A
* 类 名： T_State
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/25 14:44:42   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:T_State
	/// </summary>
	public partial class T_State
	{
		public T_State()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string StateMark)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_State");
			strSql.Append(" where StateMark=@StateMark ");
			SqlParameter[] parameters = {
					new SqlParameter("@StateMark", SqlDbType.NVarChar,25)			};
			parameters[0].Value = StateMark;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.T_State model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_State(");
			strSql.Append("StateMark,StateExplanation,StateGroup,StateValue,DeviceState)");
			strSql.Append(" values (");
			strSql.Append("@StateMark,@StateExplanation,@StateGroup,@StateValue,@DeviceState)");
			SqlParameter[] parameters = {
					new SqlParameter("@StateMark", SqlDbType.NVarChar,25),
					new SqlParameter("@StateExplanation", SqlDbType.NVarChar,50),
					new SqlParameter("@StateGroup", SqlDbType.NVarChar,255),
					new SqlParameter("@StateValue", SqlDbType.NVarChar,255),
					new SqlParameter("@DeviceState", SqlDbType.NVarChar,25)};
			parameters[0].Value = model.StateMark;
			parameters[1].Value = model.StateExplanation;
			parameters[2].Value = model.StateGroup;
			parameters[3].Value = model.StateValue;
			parameters[4].Value = model.DeviceState;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.T_State model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_State set ");
			strSql.Append("StateExplanation=@StateExplanation,");
			strSql.Append("StateGroup=@StateGroup,");
			strSql.Append("StateValue=@StateValue,");
			strSql.Append("DeviceState=@DeviceState");
			strSql.Append(" where StateMark=@StateMark ");
			SqlParameter[] parameters = {
					new SqlParameter("@StateExplanation", SqlDbType.NVarChar,50),
					new SqlParameter("@StateGroup", SqlDbType.NVarChar,255),
					new SqlParameter("@StateValue", SqlDbType.NVarChar,255),
					new SqlParameter("@DeviceState", SqlDbType.NVarChar,25),
					new SqlParameter("@StateMark", SqlDbType.NVarChar,25)};
			parameters[0].Value = model.StateExplanation;
			parameters[1].Value = model.StateGroup;
			parameters[2].Value = model.StateValue;
			parameters[3].Value = model.DeviceState;
			parameters[4].Value = model.StateMark;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string StateMark)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_State ");
			strSql.Append(" where StateMark=@StateMark ");
			SqlParameter[] parameters = {
					new SqlParameter("@StateMark", SqlDbType.NVarChar,25)			};
			parameters[0].Value = StateMark;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string StateMarklist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_State ");
			strSql.Append(" where StateMark in ("+StateMarklist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.T_State GetModel(string StateMark)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 StateMark,StateExplanation,StateGroup,StateValue,DeviceState from T_State ");
			strSql.Append(" where StateMark=@StateMark ");
			SqlParameter[] parameters = {
					new SqlParameter("@StateMark", SqlDbType.NVarChar,25)			};
			parameters[0].Value = StateMark;

			Maticsoft.Model.T_State model=new Maticsoft.Model.T_State();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.T_State DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_State model=new Maticsoft.Model.T_State();
			if (row != null)
			{
				if(row["StateMark"]!=null)
				{
					model.StateMark=row["StateMark"].ToString();
				}
				if(row["StateExplanation"]!=null)
				{
					model.StateExplanation=row["StateExplanation"].ToString();
				}
				if(row["StateGroup"]!=null)
				{
					model.StateGroup=row["StateGroup"].ToString();
				}
				if(row["StateValue"]!=null)
				{
					model.StateValue=row["StateValue"].ToString();
				}
				if(row["DeviceState"]!=null)
				{
					model.DeviceState=row["DeviceState"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select StateMark,StateExplanation,StateGroup,StateValue,DeviceState ");
			strSql.Append(" FROM T_State ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" StateMark,StateExplanation,StateGroup,StateValue,DeviceState ");
			strSql.Append(" FROM T_State ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_State ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.StateMark desc");
			}
			strSql.Append(")AS Row, T.*  from T_State T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "T_State";
			parameters[1].Value = "StateMark";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

