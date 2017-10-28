/**  版本信息模板在安装目录下，可自行修改。
* T_Area.cs
*
* 功 能： N/A
* 类 名： T_Area
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:33   N/A    初版
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
	/// 数据访问类:T_Area
	/// </summary>
	public partial class T_Area
	{
		public T_Area()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string AreaCode)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Area");
			strSql.Append(" where AreaCode=@AreaCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaCode", SqlDbType.NVarChar,15)			};
			parameters[0].Value = AreaCode;

			return DbBaseHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.T_Area model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Area(");
			strSql.Append("AreaCode,AreaName,province,city,distinguish,town,remark,reportno,realtimeaddress,historyaddress,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG)");
			strSql.Append(" values (");
			strSql.Append("@AreaCode,@AreaName,@province,@city,@distinguish,@town,@remark,@reportno,@realtimeaddress,@historyaddress,@ExcelServerRCID,@ExcelServerRN,@ExcelServerCN,@ExcelServerRC1,@ExcelServerWIID,@ExcelServerRTID,@ExcelServerCHG)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaCode", SqlDbType.NVarChar,15),
					new SqlParameter("@AreaName", SqlDbType.NVarChar,255),
					new SqlParameter("@province", SqlDbType.NVarChar,50),
					new SqlParameter("@city", SqlDbType.NVarChar,50),
					new SqlParameter("@distinguish", SqlDbType.NVarChar,50),
					new SqlParameter("@town", SqlDbType.NVarChar,50),
					new SqlParameter("@remark", SqlDbType.NVarChar,255),
					new SqlParameter("@reportno", SqlDbType.NVarChar,50),
					new SqlParameter("@realtimeaddress", SqlDbType.NVarChar,100),
					new SqlParameter("@historyaddress", SqlDbType.NVarChar,100),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4)};
			parameters[0].Value = model.AreaCode;
			parameters[1].Value = model.AreaName;
			parameters[2].Value = model.province;
			parameters[3].Value = model.city;
			parameters[4].Value = model.distinguish;
			parameters[5].Value = model.town;
			parameters[6].Value = model.remark;
			parameters[7].Value = model.reportno;
			parameters[8].Value = model.realtimeaddress;
			parameters[9].Value = model.historyaddress;
			parameters[10].Value = model.ExcelServerRCID;
			parameters[11].Value = model.ExcelServerRN;
			parameters[12].Value = model.ExcelServerCN;
			parameters[13].Value = model.ExcelServerRC1;
			parameters[14].Value = model.ExcelServerWIID;
			parameters[15].Value = model.ExcelServerRTID;
			parameters[16].Value = model.ExcelServerCHG;

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
		public bool Update(Maticsoft.Model.T_Area model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Area set ");
			strSql.Append("AreaName=@AreaName,");
			strSql.Append("province=@province,");
			strSql.Append("city=@city,");
			strSql.Append("distinguish=@distinguish,");
			strSql.Append("town=@town,");
			strSql.Append("remark=@remark,");
			strSql.Append("reportno=@reportno,");
			strSql.Append("realtimeaddress=@realtimeaddress,");
			strSql.Append("historyaddress=@historyaddress,");
			strSql.Append("ExcelServerRCID=@ExcelServerRCID,");
			strSql.Append("ExcelServerRN=@ExcelServerRN,");
			strSql.Append("ExcelServerCN=@ExcelServerCN,");
			strSql.Append("ExcelServerRC1=@ExcelServerRC1,");
			strSql.Append("ExcelServerWIID=@ExcelServerWIID,");
			strSql.Append("ExcelServerRTID=@ExcelServerRTID,");
			strSql.Append("ExcelServerCHG=@ExcelServerCHG");
			strSql.Append(" where AreaID=@AreaID");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaName", SqlDbType.NVarChar,255),
					new SqlParameter("@province", SqlDbType.NVarChar,50),
					new SqlParameter("@city", SqlDbType.NVarChar,50),
					new SqlParameter("@distinguish", SqlDbType.NVarChar,50),
					new SqlParameter("@town", SqlDbType.NVarChar,50),
					new SqlParameter("@remark", SqlDbType.NVarChar,255),
					new SqlParameter("@reportno", SqlDbType.NVarChar,50),
					new SqlParameter("@realtimeaddress", SqlDbType.NVarChar,100),
					new SqlParameter("@historyaddress", SqlDbType.NVarChar,100),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@AreaID", SqlDbType.Int,4),
					new SqlParameter("@AreaCode", SqlDbType.NVarChar,15)};
			parameters[0].Value = model.AreaName;
			parameters[1].Value = model.province;
			parameters[2].Value = model.city;
			parameters[3].Value = model.distinguish;
			parameters[4].Value = model.town;
			parameters[5].Value = model.remark;
			parameters[6].Value = model.reportno;
			parameters[7].Value = model.realtimeaddress;
			parameters[8].Value = model.historyaddress;
			parameters[9].Value = model.ExcelServerRCID;
			parameters[10].Value = model.ExcelServerRN;
			parameters[11].Value = model.ExcelServerCN;
			parameters[12].Value = model.ExcelServerRC1;
			parameters[13].Value = model.ExcelServerWIID;
			parameters[14].Value = model.ExcelServerRTID;
			parameters[15].Value = model.ExcelServerCHG;
			parameters[16].Value = model.AreaID;
			parameters[17].Value = model.AreaCode;

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
		public bool Delete(int AreaID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Area ");
			strSql.Append(" where AreaID=@AreaID");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaID", SqlDbType.Int,4)
			};
			parameters[0].Value = AreaID;

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
		public bool Delete(string AreaCode)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Area ");
			strSql.Append(" where AreaCode=@AreaCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaCode", SqlDbType.NVarChar,15)			};
			parameters[0].Value = AreaCode;

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
		public bool DeleteList(string AreaIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Area ");
			strSql.Append(" where AreaID in ("+AreaIDlist + ")  ");
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
		public Maticsoft.Model.T_Area GetModel(int AreaID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AreaID,AreaCode,AreaName,province,city,distinguish,town,remark,reportno,realtimeaddress,historyaddress,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG from T_Area ");
			strSql.Append(" where AreaID=@AreaID");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaID", SqlDbType.Int,4)
			};
			parameters[0].Value = AreaID;

			Maticsoft.Model.T_Area model=new Maticsoft.Model.T_Area();
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
		public Maticsoft.Model.T_Area DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_Area model=new Maticsoft.Model.T_Area();
			if (row != null)
			{
				if(row["AreaID"]!=null && row["AreaID"].ToString()!="")
				{
					model.AreaID=int.Parse(row["AreaID"].ToString());
				}
				if(row["AreaCode"]!=null)
				{
					model.AreaCode=row["AreaCode"].ToString();
				}
				if(row["AreaName"]!=null)
				{
					model.AreaName=row["AreaName"].ToString();
				}
				if(row["province"]!=null)
				{
					model.province=row["province"].ToString();
				}
				if(row["city"]!=null)
				{
					model.city=row["city"].ToString();
				}
				if(row["distinguish"]!=null)
				{
					model.distinguish=row["distinguish"].ToString();
				}
				if(row["town"]!=null)
				{
					model.town=row["town"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["reportno"]!=null)
				{
					model.reportno=row["reportno"].ToString();
				}
				if(row["realtimeaddress"]!=null)
				{
					model.realtimeaddress=row["realtimeaddress"].ToString();
				}
				if(row["historyaddress"]!=null)
				{
					model.historyaddress=row["historyaddress"].ToString();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select AreaID,AreaCode,AreaName,province,city,distinguish,town,remark,reportno,realtimeaddress,historyaddress,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG ");
			strSql.Append(" FROM T_Area ");
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
			strSql.Append(" AreaID,AreaCode,AreaName,province,city,distinguish,town,remark,reportno,realtimeaddress,historyaddress,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG ");
			strSql.Append(" FROM T_Area ");
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
			strSql.Append("select count(1) FROM T_Area ");
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
				strSql.Append("order by T.AreaID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Area T ");
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
			parameters[0].Value = "T_Area";
			parameters[1].Value = "AreaID";
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

