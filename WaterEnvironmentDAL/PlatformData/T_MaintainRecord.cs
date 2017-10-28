/**  版本信息模板在安装目录下，可自行修改。
* T_MaintainRecord.cs
*
* 功 能： N/A
* 类 名： T_MaintainRecord
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/25 14:44:30   N/A    初版
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
	/// 数据访问类:T_MaintainRecord
	/// </summary>
	public partial class T_MaintainRecord
	{
		public T_MaintainRecord()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "T_MaintainRecord"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_MaintainRecord");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.T_MaintainRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_MaintainRecord(");
			strSql.Append("Id,PointID,MaintainType,StartTime,EndTime,SpentTime,LastMaintainTime,Content,WriteTime,WritePerson)");
			strSql.Append(" values (");
			strSql.Append("@Id,@PointID,@MaintainType,@StartTime,@EndTime,@SpentTime,@LastMaintainTime,@Content,@WriteTime,@WritePerson)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@MaintainType", SqlDbType.NVarChar,25),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@SpentTime", SqlDbType.Float,8),
					new SqlParameter("@LastMaintainTime", SqlDbType.DateTime),
					new SqlParameter("@Content", SqlDbType.NVarChar,-1),
					new SqlParameter("@WriteTime", SqlDbType.DateTime),
					new SqlParameter("@WritePerson", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.PointID;
			parameters[2].Value = model.MaintainType;
			parameters[3].Value = model.StartTime;
			parameters[4].Value = model.EndTime;
			parameters[5].Value = model.SpentTime;
			parameters[6].Value = model.LastMaintainTime;
			parameters[7].Value = model.Content;
			parameters[8].Value = model.WriteTime;
			parameters[9].Value = model.WritePerson;

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
		public bool Update(Maticsoft.Model.T_MaintainRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_MaintainRecord set ");
			strSql.Append("PointID=@PointID,");
			strSql.Append("MaintainType=@MaintainType,");
			strSql.Append("StartTime=@StartTime,");
			strSql.Append("EndTime=@EndTime,");
			strSql.Append("SpentTime=@SpentTime,");
			strSql.Append("LastMaintainTime=@LastMaintainTime,");
			strSql.Append("Content=@Content,");
			strSql.Append("WriteTime=@WriteTime,");
			strSql.Append("WritePerson=@WritePerson");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@MaintainType", SqlDbType.NVarChar,25),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@SpentTime", SqlDbType.Float,8),
					new SqlParameter("@LastMaintainTime", SqlDbType.DateTime),
					new SqlParameter("@Content", SqlDbType.NVarChar,-1),
					new SqlParameter("@WriteTime", SqlDbType.DateTime),
					new SqlParameter("@WritePerson", SqlDbType.NVarChar,100),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.PointID;
			parameters[1].Value = model.MaintainType;
			parameters[2].Value = model.StartTime;
			parameters[3].Value = model.EndTime;
			parameters[4].Value = model.SpentTime;
			parameters[5].Value = model.LastMaintainTime;
			parameters[6].Value = model.Content;
			parameters[7].Value = model.WriteTime;
			parameters[8].Value = model.WritePerson;
			parameters[9].Value = model.Id;

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
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_MaintainRecord ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_MaintainRecord ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
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
		public Maticsoft.Model.T_MaintainRecord GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,PointID,MaintainType,StartTime,EndTime,SpentTime,LastMaintainTime,Content,WriteTime,WritePerson from T_MaintainRecord ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			Maticsoft.Model.T_MaintainRecord model=new Maticsoft.Model.T_MaintainRecord();
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
		public Maticsoft.Model.T_MaintainRecord DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_MaintainRecord model=new Maticsoft.Model.T_MaintainRecord();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["PointID"]!=null && row["PointID"].ToString()!="")
				{
					model.PointID=int.Parse(row["PointID"].ToString());
				}
				if(row["MaintainType"]!=null)
				{
					model.MaintainType=row["MaintainType"].ToString();
				}
				if(row["StartTime"]!=null && row["StartTime"].ToString()!="")
				{
					model.StartTime=DateTime.Parse(row["StartTime"].ToString());
				}
				if(row["EndTime"]!=null && row["EndTime"].ToString()!="")
				{
					model.EndTime=DateTime.Parse(row["EndTime"].ToString());
				}
				if(row["SpentTime"]!=null && row["SpentTime"].ToString()!="")
				{
					model.SpentTime=decimal.Parse(row["SpentTime"].ToString());
				}
				if(row["LastMaintainTime"]!=null && row["LastMaintainTime"].ToString()!="")
				{
					model.LastMaintainTime=DateTime.Parse(row["LastMaintainTime"].ToString());
				}
				if(row["Content"]!=null)
				{
					model.Content=row["Content"].ToString();
				}
				if(row["WriteTime"]!=null && row["WriteTime"].ToString()!="")
				{
					model.WriteTime=DateTime.Parse(row["WriteTime"].ToString());
				}
				if(row["WritePerson"]!=null)
				{
					model.WritePerson=row["WritePerson"].ToString();
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
			strSql.Append("select Id,PointID,MaintainType,StartTime,EndTime,SpentTime,LastMaintainTime,Content,WriteTime,WritePerson ");
			strSql.Append(" FROM T_MaintainRecord ");
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
			strSql.Append(" Id,PointID,MaintainType,StartTime,EndTime,SpentTime,LastMaintainTime,Content,WriteTime,WritePerson ");
			strSql.Append(" FROM T_MaintainRecord ");
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
			strSql.Append("select count(1) FROM T_MaintainRecord ");
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
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from T_MaintainRecord T ");
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
			parameters[0].Value = "T_MaintainRecord";
			parameters[1].Value = "Id";
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

