/**  版本信息模板在安装目录下，可自行修改。
* T_TransmitSet.cs
*
* 功 能： N/A
* 类 名： T_TransmitSet
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/25 14:44:51   N/A    初版
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
	/// 数据访问类:T_TransmitSet
	/// </summary>
	public partial class T_TransmitSet
	{
		public T_TransmitSet()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("TransmitPort", "T_TransmitSet"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string MNCode,string TransmitIp,int TransmitPort)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_TransmitSet");
			strSql.Append(" where MNCode=@MNCode and TransmitIp=@TransmitIp and TransmitPort=@TransmitPort ");
			SqlParameter[] parameters = {
					new SqlParameter("@MNCode", SqlDbType.NVarChar,25),
					new SqlParameter("@TransmitIp", SqlDbType.NVarChar,255),
					new SqlParameter("@TransmitPort", SqlDbType.Int,4)			};
			parameters[0].Value = MNCode;
			parameters[1].Value = TransmitIp;
			parameters[2].Value = TransmitPort;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.T_TransmitSet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_TransmitSet(");
			strSql.Append("MNCode,TransmitIp,TransmitPort,IsUsed)");
			strSql.Append(" values (");
			strSql.Append("@MNCode,@TransmitIp,@TransmitPort,@IsUsed)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MNCode", SqlDbType.NVarChar,25),
					new SqlParameter("@TransmitIp", SqlDbType.NVarChar,255),
					new SqlParameter("@TransmitPort", SqlDbType.Int,4),
					new SqlParameter("@IsUsed", SqlDbType.Bit,1)};
			parameters[0].Value = model.MNCode;
			parameters[1].Value = model.TransmitIp;
			parameters[2].Value = model.TransmitPort;
			parameters[3].Value = model.IsUsed;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.T_TransmitSet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_TransmitSet set ");
			strSql.Append("IsUsed=@IsUsed");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@IsUsed", SqlDbType.Bit,1),
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MNCode", SqlDbType.NVarChar,25),
					new SqlParameter("@TransmitIp", SqlDbType.NVarChar,255),
					new SqlParameter("@TransmitPort", SqlDbType.Int,4)};
			parameters[0].Value = model.IsUsed;
			parameters[1].Value = model.ID;
			parameters[2].Value = model.MNCode;
			parameters[3].Value = model.TransmitIp;
			parameters[4].Value = model.TransmitPort;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_TransmitSet ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

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
		public bool Delete(string MNCode,string TransmitIp,int TransmitPort)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_TransmitSet ");
			strSql.Append(" where MNCode=@MNCode and TransmitIp=@TransmitIp and TransmitPort=@TransmitPort ");
			SqlParameter[] parameters = {
					new SqlParameter("@MNCode", SqlDbType.NVarChar,25),
					new SqlParameter("@TransmitIp", SqlDbType.NVarChar,255),
					new SqlParameter("@TransmitPort", SqlDbType.Int,4)			};
			parameters[0].Value = MNCode;
			parameters[1].Value = TransmitIp;
			parameters[2].Value = TransmitPort;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_TransmitSet ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public Maticsoft.Model.T_TransmitSet GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MNCode,TransmitIp,TransmitPort,IsUsed from T_TransmitSet ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Maticsoft.Model.T_TransmitSet model=new Maticsoft.Model.T_TransmitSet();
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
		public Maticsoft.Model.T_TransmitSet DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_TransmitSet model=new Maticsoft.Model.T_TransmitSet();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["MNCode"]!=null)
				{
					model.MNCode=row["MNCode"].ToString();
				}
				if(row["TransmitIp"]!=null)
				{
					model.TransmitIp=row["TransmitIp"].ToString();
				}
				if(row["TransmitPort"]!=null && row["TransmitPort"].ToString()!="")
				{
					model.TransmitPort=int.Parse(row["TransmitPort"].ToString());
				}
				if(row["IsUsed"]!=null && row["IsUsed"].ToString()!="")
				{
					if((row["IsUsed"].ToString()=="1")||(row["IsUsed"].ToString().ToLower()=="true"))
					{
						model.IsUsed=true;
					}
					else
					{
						model.IsUsed=false;
					}
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
			strSql.Append("select ID,MNCode,TransmitIp,TransmitPort,IsUsed ");
			strSql.Append(" FROM T_TransmitSet ");
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
			strSql.Append(" ID,MNCode,TransmitIp,TransmitPort,IsUsed ");
			strSql.Append(" FROM T_TransmitSet ");
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
			strSql.Append("select count(1) FROM T_TransmitSet ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from T_TransmitSet T ");
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
			parameters[0].Value = "T_TransmitSet";
			parameters[1].Value = "ID";
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

