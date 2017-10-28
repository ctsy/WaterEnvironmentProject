/**  版本信息模板在安装目录下，可自行修改。
* T_Instrument.cs
*
* 功 能： N/A
* 类 名： T_Instrument
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:42   N/A    初版
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
	/// 数据访问类:T_Instrument
	/// </summary>
	public partial class T_Instrument
	{
		public T_Instrument()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.T_Instrument model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Instrument(");
			strSql.Append("InstrumentID,InstrumentName,InstrumentModel,InstrumentType,SupplierId,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,KingdeeId,InnerId,Remark)");
			strSql.Append(" values (");
			strSql.Append("@InstrumentID,@InstrumentName,@InstrumentModel,@InstrumentType,@SupplierId,@ExcelServerRCID,@ExcelServerRN,@ExcelServerCN,@ExcelServerRC1,@ExcelServerWIID,@ExcelServerRTID,@ExcelServerCHG,@KingdeeId,@InnerId,@Remark)");
			SqlParameter[] parameters = {
					new SqlParameter("@InstrumentID", SqlDbType.Int,4),
					new SqlParameter("@InstrumentName", SqlDbType.NVarChar,255),
					new SqlParameter("@InstrumentModel", SqlDbType.NVarChar,100),
					new SqlParameter("@InstrumentType", SqlDbType.NVarChar,50),
					new SqlParameter("@SupplierId", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@KingdeeId", SqlDbType.NVarChar,20),
					new SqlParameter("@InnerId", SqlDbType.NVarChar,20),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.InstrumentID;
			parameters[1].Value = model.InstrumentName;
			parameters[2].Value = model.InstrumentModel;
			parameters[3].Value = model.InstrumentType;
			parameters[4].Value = model.SupplierId;
			parameters[5].Value = model.ExcelServerRCID;
			parameters[6].Value = model.ExcelServerRN;
			parameters[7].Value = model.ExcelServerCN;
			parameters[8].Value = model.ExcelServerRC1;
			parameters[9].Value = model.ExcelServerWIID;
			parameters[10].Value = model.ExcelServerRTID;
			parameters[11].Value = model.ExcelServerCHG;
			parameters[12].Value = model.KingdeeId;
			parameters[13].Value = model.InnerId;
			parameters[14].Value = model.Remark;

			int rows=DbBaseHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(Maticsoft.Model.T_Instrument model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Instrument set ");
			strSql.Append("InstrumentID=@InstrumentID,");
			strSql.Append("InstrumentName=@InstrumentName,");
			strSql.Append("InstrumentModel=@InstrumentModel,");
			strSql.Append("InstrumentType=@InstrumentType,");
			strSql.Append("SupplierId=@SupplierId,");
			strSql.Append("ExcelServerRCID=@ExcelServerRCID,");
			strSql.Append("ExcelServerRN=@ExcelServerRN,");
			strSql.Append("ExcelServerCN=@ExcelServerCN,");
			strSql.Append("ExcelServerRC1=@ExcelServerRC1,");
			strSql.Append("ExcelServerWIID=@ExcelServerWIID,");
			strSql.Append("ExcelServerRTID=@ExcelServerRTID,");
			strSql.Append("ExcelServerCHG=@ExcelServerCHG,");
			strSql.Append("KingdeeId=@KingdeeId,");
			strSql.Append("InnerId=@InnerId,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@InstrumentID", SqlDbType.Int,4),
					new SqlParameter("@InstrumentName", SqlDbType.NVarChar,255),
					new SqlParameter("@InstrumentModel", SqlDbType.NVarChar,100),
					new SqlParameter("@InstrumentType", SqlDbType.NVarChar,50),
					new SqlParameter("@SupplierId", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@KingdeeId", SqlDbType.NVarChar,20),
					new SqlParameter("@InnerId", SqlDbType.NVarChar,20),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.InstrumentID;
			parameters[1].Value = model.InstrumentName;
			parameters[2].Value = model.InstrumentModel;
			parameters[3].Value = model.InstrumentType;
			parameters[4].Value = model.SupplierId;
			parameters[5].Value = model.ExcelServerRCID;
			parameters[6].Value = model.ExcelServerRN;
			parameters[7].Value = model.ExcelServerCN;
			parameters[8].Value = model.ExcelServerRC1;
			parameters[9].Value = model.ExcelServerWIID;
			parameters[10].Value = model.ExcelServerRTID;
			parameters[11].Value = model.ExcelServerCHG;
			parameters[12].Value = model.KingdeeId;
			parameters[13].Value = model.InnerId;
			parameters[14].Value = model.Remark;

			int rows=DbBaseHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Instrument ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			int rows=DbBaseHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public Maticsoft.Model.T_Instrument GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 InstrumentID,InstrumentName,InstrumentModel,InstrumentType,SupplierId,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,KingdeeId,InnerId,Remark from T_Instrument ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.T_Instrument model=new Maticsoft.Model.T_Instrument();
			DataSet ds=DbBaseHelperSQL.Query(strSql.ToString(),parameters);
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
		public Maticsoft.Model.T_Instrument DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_Instrument model=new Maticsoft.Model.T_Instrument();
			if (row != null)
			{
				if(row["InstrumentID"]!=null && row["InstrumentID"].ToString()!="")
				{
					model.InstrumentID=int.Parse(row["InstrumentID"].ToString());
				}
				if(row["InstrumentName"]!=null)
				{
					model.InstrumentName=row["InstrumentName"].ToString();
				}
				if(row["InstrumentModel"]!=null)
				{
					model.InstrumentModel=row["InstrumentModel"].ToString();
				}
				if(row["InstrumentType"]!=null)
				{
					model.InstrumentType=row["InstrumentType"].ToString();
				}
				if(row["SupplierId"]!=null && row["SupplierId"].ToString()!="")
				{
					model.SupplierId=int.Parse(row["SupplierId"].ToString());
				}
				if(row["ExcelServerRCID"]!=null)
				{
					model.ExcelServerRCID=row["ExcelServerRCID"].ToString();
				}
				if(row["ExcelServerRN"]!=null && row["ExcelServerRN"].ToString()!="")
				{
					model.ExcelServerRN=int.Parse(row["ExcelServerRN"].ToString());
				}
				if(row["ExcelServerCN"]!=null && row["ExcelServerCN"].ToString()!="")
				{
					model.ExcelServerCN=int.Parse(row["ExcelServerCN"].ToString());
				}
				if(row["ExcelServerRC1"]!=null)
				{
					model.ExcelServerRC1=row["ExcelServerRC1"].ToString();
				}
				if(row["ExcelServerWIID"]!=null)
				{
					model.ExcelServerWIID=row["ExcelServerWIID"].ToString();
				}
				if(row["ExcelServerRTID"]!=null)
				{
					model.ExcelServerRTID=row["ExcelServerRTID"].ToString();
				}
				if(row["ExcelServerCHG"]!=null && row["ExcelServerCHG"].ToString()!="")
				{
					model.ExcelServerCHG=int.Parse(row["ExcelServerCHG"].ToString());
				}
				if(row["KingdeeId"]!=null)
				{
					model.KingdeeId=row["KingdeeId"].ToString();
				}
				if(row["InnerId"]!=null)
				{
					model.InnerId=row["InnerId"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
			strSql.Append("select InstrumentID,InstrumentName,InstrumentModel,InstrumentType,SupplierId,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,KingdeeId,InnerId,Remark ");
			strSql.Append(" FROM T_Instrument ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbBaseHelperSQL.Query(strSql.ToString());
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
			strSql.Append(" InstrumentID,InstrumentName,InstrumentModel,InstrumentType,SupplierId,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,KingdeeId,InnerId,Remark ");
			strSql.Append(" FROM T_Instrument ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbBaseHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_Instrument ");
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
				strSql.Append("order by T.geneID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Instrument T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbBaseHelperSQL.Query(strSql.ToString());
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
			parameters[0].Value = "T_Instrument";
			parameters[1].Value = "geneID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbBaseHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

