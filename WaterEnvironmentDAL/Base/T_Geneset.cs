/**  版本信息模板在安装目录下，可自行修改。
* T_Geneset.cs
*
* 功 能： N/A
* 类 名： T_Geneset
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:40   N/A    初版
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
	/// 数据访问类:T_Geneset
	/// </summary>
	public partial class T_Geneset
	{
		public T_Geneset()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.T_Geneset model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Geneset(");
			strSql.Append("genename,genecode,genecodeExpand,geneT212,unit,m_decimal,DataType,ZS,remark,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,GeneType)");
			strSql.Append(" values (");
			strSql.Append("@genename,@genecode,@genecodeExpand,@geneT212,@unit,@m_decimal,@DataType,@ZS,@remark,@ExcelServerRCID,@ExcelServerRN,@ExcelServerCN,@ExcelServerRC1,@ExcelServerWIID,@ExcelServerRTID,@ExcelServerCHG,@GeneType)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@genename", SqlDbType.NVarChar,255),
					new SqlParameter("@genecode", SqlDbType.NVarChar,50),
					new SqlParameter("@genecodeExpand", SqlDbType.NVarChar,50),
					new SqlParameter("@geneT212", SqlDbType.NVarChar,50),
					new SqlParameter("@unit", SqlDbType.VarChar,50),
					new SqlParameter("@m_decimal", SqlDbType.Int,4),
					new SqlParameter("@DataType", SqlDbType.Int,4),
					new SqlParameter("@ZS", SqlDbType.Bit,1),
					new SqlParameter("@remark", SqlDbType.NVarChar,500),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@GeneType", SqlDbType.Int,4)};
			parameters[0].Value = model.genename;
			parameters[1].Value = model.genecode;
			parameters[2].Value = model.genecodeExpand;
			parameters[3].Value = model.geneT212;
			parameters[4].Value = model.unit;
			parameters[5].Value = model.m_decimal;
			parameters[6].Value = model.DataType;
			parameters[7].Value = model.ZS;
			parameters[8].Value = model.remark;
			parameters[9].Value = model.ExcelServerRCID;
			parameters[10].Value = model.ExcelServerRN;
			parameters[11].Value = model.ExcelServerCN;
			parameters[12].Value = model.ExcelServerRC1;
			parameters[13].Value = model.ExcelServerWIID;
			parameters[14].Value = model.ExcelServerRTID;
			parameters[15].Value = model.ExcelServerCHG;
			parameters[16].Value = model.GeneType;

			object obj = DbBaseHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(Maticsoft.Model.T_Geneset model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Geneset set ");
			strSql.Append("genename=@genename,");
			strSql.Append("genecode=@genecode,");
			strSql.Append("genecodeExpand=@genecodeExpand,");
			strSql.Append("geneT212=@geneT212,");
			strSql.Append("unit=@unit,");
			strSql.Append("m_decimal=@m_decimal,");
			strSql.Append("DataType=@DataType,");
			strSql.Append("ZS=@ZS,");
			strSql.Append("remark=@remark,");
			strSql.Append("ExcelServerRCID=@ExcelServerRCID,");
			strSql.Append("ExcelServerRN=@ExcelServerRN,");
			strSql.Append("ExcelServerCN=@ExcelServerCN,");
			strSql.Append("ExcelServerRC1=@ExcelServerRC1,");
			strSql.Append("ExcelServerWIID=@ExcelServerWIID,");
			strSql.Append("ExcelServerRTID=@ExcelServerRTID,");
			strSql.Append("ExcelServerCHG=@ExcelServerCHG,");
			strSql.Append("GeneType=@GeneType");
			strSql.Append(" where geneID=@geneID");
			SqlParameter[] parameters = {
					new SqlParameter("@genename", SqlDbType.NVarChar,255),
					new SqlParameter("@genecode", SqlDbType.NVarChar,50),
					new SqlParameter("@genecodeExpand", SqlDbType.NVarChar,50),
					new SqlParameter("@geneT212", SqlDbType.NVarChar,50),
					new SqlParameter("@unit", SqlDbType.VarChar,50),
					new SqlParameter("@m_decimal", SqlDbType.Int,4),
					new SqlParameter("@DataType", SqlDbType.Int,4),
					new SqlParameter("@ZS", SqlDbType.Bit,1),
					new SqlParameter("@remark", SqlDbType.NVarChar,500),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@GeneType", SqlDbType.Int,4),
					new SqlParameter("@geneID", SqlDbType.Int,4)};
			parameters[0].Value = model.genename;
			parameters[1].Value = model.genecode;
			parameters[2].Value = model.genecodeExpand;
			parameters[3].Value = model.geneT212;
			parameters[4].Value = model.unit;
			parameters[5].Value = model.m_decimal;
			parameters[6].Value = model.DataType;
			parameters[7].Value = model.ZS;
			parameters[8].Value = model.remark;
			parameters[9].Value = model.ExcelServerRCID;
			parameters[10].Value = model.ExcelServerRN;
			parameters[11].Value = model.ExcelServerCN;
			parameters[12].Value = model.ExcelServerRC1;
			parameters[13].Value = model.ExcelServerWIID;
			parameters[14].Value = model.ExcelServerRTID;
			parameters[15].Value = model.ExcelServerCHG;
			parameters[16].Value = model.GeneType;
			parameters[17].Value = model.geneID;

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
		public bool Delete(int geneID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Geneset ");
			strSql.Append(" where geneID=@geneID");
			SqlParameter[] parameters = {
					new SqlParameter("@geneID", SqlDbType.Int,4)
			};
			parameters[0].Value = geneID;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string geneIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Geneset ");
			strSql.Append(" where geneID in ("+geneIDlist + ")  ");
			int rows=DbBaseHelperSQL.ExecuteSql(strSql.ToString());
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
		public Maticsoft.Model.T_Geneset GetModel(int geneID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 geneID,genename,genecode,genecodeExpand,geneT212,unit,m_decimal,DataType,ZS,remark,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,GeneType from T_Geneset ");
			strSql.Append(" where geneID=@geneID");
			SqlParameter[] parameters = {
					new SqlParameter("@geneID", SqlDbType.Int,4)
			};
			parameters[0].Value = geneID;

			Maticsoft.Model.T_Geneset model=new Maticsoft.Model.T_Geneset();
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
		public Maticsoft.Model.T_Geneset DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_Geneset model=new Maticsoft.Model.T_Geneset();
			if (row != null)
			{
				if(row["geneID"]!=null && row["geneID"].ToString()!="")
				{
					model.geneID=int.Parse(row["geneID"].ToString());
				}
				if(row["genename"]!=null)
				{
					model.genename=row["genename"].ToString();
				}
				if(row["genecode"]!=null)
				{
					model.genecode=row["genecode"].ToString();
				}
				if(row["genecodeExpand"]!=null)
				{
					model.genecodeExpand=row["genecodeExpand"].ToString();
				}
				if(row["geneT212"]!=null)
				{
					model.geneT212=row["geneT212"].ToString();
				}
				if(row["unit"]!=null)
				{
					model.unit=row["unit"].ToString();
				}
				if(row["m_decimal"]!=null && row["m_decimal"].ToString()!="")
				{
					model.m_decimal=int.Parse(row["m_decimal"].ToString());
				}
				if(row["DataType"]!=null && row["DataType"].ToString()!="")
				{
					model.DataType=int.Parse(row["DataType"].ToString());
				}
				if(row["ZS"]!=null && row["ZS"].ToString()!="")
				{
					if((row["ZS"].ToString()=="1")||(row["ZS"].ToString().ToLower()=="true"))
					{
						model.ZS=true;
					}
					else
					{
						model.ZS=false;
					}
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
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
				if(row["GeneType"]!=null && row["GeneType"].ToString()!="")
				{
					model.GeneType=int.Parse(row["GeneType"].ToString());
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
			strSql.Append("select geneID,genename,genecode,genecodeExpand,geneT212,unit,m_decimal,DataType,ZS,remark,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,GeneType ");
			strSql.Append(" FROM T_Geneset ");
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
			strSql.Append(" geneID,genename,genecode,genecodeExpand,geneT212,unit,m_decimal,DataType,ZS,remark,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,GeneType ");
			strSql.Append(" FROM T_Geneset ");
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
			strSql.Append("select count(1) FROM T_Geneset ");
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
			strSql.Append(")AS Row, T.*  from T_Geneset T ");
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
			parameters[0].Value = "T_Geneset";
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

