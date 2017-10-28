/**  版本信息模板在安装目录下，可自行修改。
* T_Contractor.cs
*
* 功 能： N/A
* 类 名： T_Contractor
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:35   N/A    初版
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
	/// 数据访问类:T_Contractor
	/// </summary>
	public partial class T_Contractor
	{
		public T_Contractor()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.T_Contractor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Contractor(");
			strSql.Append("ContractorID,CompanyCode,Name,cellphone,telephone,remark,qq,email,fax,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,RecordFlag)");
			strSql.Append(" values (");
			strSql.Append("@ContractorID,@CompanyCode,@Name,@cellphone,@telephone,@remark,@qq,@email,@fax,@ExcelServerRCID,@ExcelServerRN,@ExcelServerCN,@ExcelServerRC1,@ExcelServerWIID,@ExcelServerRTID,@ExcelServerCHG,@RecordFlag)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ContractorID", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,255),
					new SqlParameter("@Name", SqlDbType.NVarChar,255),
					new SqlParameter("@cellphone", SqlDbType.NVarChar,255),
					new SqlParameter("@telephone", SqlDbType.NVarChar,255),
					new SqlParameter("@remark", SqlDbType.NVarChar,255),
					new SqlParameter("@qq", SqlDbType.NVarChar,255),
					new SqlParameter("@email", SqlDbType.NVarChar,255),
					new SqlParameter("@fax", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@RecordFlag", SqlDbType.NVarChar,25)};
			parameters[0].Value = model.ContractorID;
			parameters[1].Value = model.CompanyCode;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.cellphone;
			parameters[4].Value = model.telephone;
			parameters[5].Value = model.remark;
			parameters[6].Value = model.qq;
			parameters[7].Value = model.email;
			parameters[8].Value = model.fax;
			parameters[9].Value = model.ExcelServerRCID;
			parameters[10].Value = model.ExcelServerRN;
			parameters[11].Value = model.ExcelServerCN;
			parameters[12].Value = model.ExcelServerRC1;
			parameters[13].Value = model.ExcelServerWIID;
			parameters[14].Value = model.ExcelServerRTID;
			parameters[15].Value = model.ExcelServerCHG;
			parameters[16].Value = model.RecordFlag;

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
		public bool Update(Maticsoft.Model.T_Contractor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Contractor set ");
			strSql.Append("ContractorID=@ContractorID,");
			strSql.Append("CompanyCode=@CompanyCode,");
			strSql.Append("Name=@Name,");
			strSql.Append("cellphone=@cellphone,");
			strSql.Append("telephone=@telephone,");
			strSql.Append("remark=@remark,");
			strSql.Append("qq=@qq,");
			strSql.Append("email=@email,");
			strSql.Append("fax=@fax,");
			strSql.Append("ExcelServerRCID=@ExcelServerRCID,");
			strSql.Append("ExcelServerRN=@ExcelServerRN,");
			strSql.Append("ExcelServerCN=@ExcelServerCN,");
			strSql.Append("ExcelServerRC1=@ExcelServerRC1,");
			strSql.Append("ExcelServerWIID=@ExcelServerWIID,");
			strSql.Append("ExcelServerRTID=@ExcelServerRTID,");
			strSql.Append("ExcelServerCHG=@ExcelServerCHG,");
			strSql.Append("RecordFlag=@RecordFlag");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ContractorID", SqlDbType.NVarChar,255),
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,255),
					new SqlParameter("@Name", SqlDbType.NVarChar,255),
					new SqlParameter("@cellphone", SqlDbType.NVarChar,255),
					new SqlParameter("@telephone", SqlDbType.NVarChar,255),
					new SqlParameter("@remark", SqlDbType.NVarChar,255),
					new SqlParameter("@qq", SqlDbType.NVarChar,255),
					new SqlParameter("@email", SqlDbType.NVarChar,255),
					new SqlParameter("@fax", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@RecordFlag", SqlDbType.NVarChar,25),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.ContractorID;
			parameters[1].Value = model.CompanyCode;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.cellphone;
			parameters[4].Value = model.telephone;
			parameters[5].Value = model.remark;
			parameters[6].Value = model.qq;
			parameters[7].Value = model.email;
			parameters[8].Value = model.fax;
			parameters[9].Value = model.ExcelServerRCID;
			parameters[10].Value = model.ExcelServerRN;
			parameters[11].Value = model.ExcelServerCN;
			parameters[12].Value = model.ExcelServerRC1;
			parameters[13].Value = model.ExcelServerWIID;
			parameters[14].Value = model.ExcelServerRTID;
			parameters[15].Value = model.ExcelServerCHG;
			parameters[16].Value = model.RecordFlag;
			parameters[17].Value = model.ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Contractor ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Contractor ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public Maticsoft.Model.T_Contractor GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ContractorID,CompanyCode,Name,cellphone,telephone,remark,qq,email,fax,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,ID,RecordFlag from T_Contractor ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Maticsoft.Model.T_Contractor model=new Maticsoft.Model.T_Contractor();
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
		public Maticsoft.Model.T_Contractor DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_Contractor model=new Maticsoft.Model.T_Contractor();
			if (row != null)
			{
				if(row["ContractorID"]!=null)
				{
					model.ContractorID=row["ContractorID"].ToString();
				}
				if(row["CompanyCode"]!=null)
				{
					model.CompanyCode=row["CompanyCode"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["cellphone"]!=null)
				{
					model.cellphone=row["cellphone"].ToString();
				}
				if(row["telephone"]!=null)
				{
					model.telephone=row["telephone"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["qq"]!=null)
				{
					model.qq=row["qq"].ToString();
				}
				if(row["email"]!=null)
				{
					model.email=row["email"].ToString();
				}
				if(row["fax"]!=null)
				{
					model.fax=row["fax"].ToString();
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
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["RecordFlag"]!=null)
				{
					model.RecordFlag=row["RecordFlag"].ToString();
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
			strSql.Append("select ContractorID,CompanyCode,Name,cellphone,telephone,remark,qq,email,fax,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,ID,RecordFlag ");
			strSql.Append(" FROM T_Contractor ");
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
			strSql.Append(" ContractorID,CompanyCode,Name,cellphone,telephone,remark,qq,email,fax,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,ID,RecordFlag ");
			strSql.Append(" FROM T_Contractor ");
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
			strSql.Append("select count(1) FROM T_Contractor ");
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
			strSql.Append(")AS Row, T.*  from T_Contractor T ");
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
			parameters[0].Value = "T_Contractor";
			parameters[1].Value = "ID";
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

