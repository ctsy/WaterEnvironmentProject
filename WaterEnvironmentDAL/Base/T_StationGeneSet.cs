/**  版本信息模板在安装目录下，可自行修改。
* T_StationGeneSet.cs
*
* 功 能： N/A
* 类 名： T_StationGeneSet
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:53   N/A    初版
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
	/// 数据访问类:T_StationGeneSet
	/// </summary>
	public partial class T_StationGeneSet
	{
		public T_StationGeneSet()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.T_StationGeneSet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_StationGeneSet(");
			strSql.Append("PointCode,GeneCode,DevCode,isStop,DayNum,StandardValue,DayMaxValue,DayMinValue,ChangeType,ChangeRate,Multiple,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG)");
			strSql.Append(" values (");
			strSql.Append("@PointCode,@GeneCode,@DevCode,@isStop,@DayNum,@StandardValue,@DayMaxValue,@DayMinValue,@ChangeType,@ChangeRate,@Multiple,@ExcelServerRCID,@ExcelServerRN,@ExcelServerCN,@ExcelServerRC1,@ExcelServerWIID,@ExcelServerRTID,@ExcelServerCHG)");
			SqlParameter[] parameters = {
					new SqlParameter("@PointCode", SqlDbType.NVarChar,50),
					new SqlParameter("@GeneCode", SqlDbType.NVarChar,50),
					new SqlParameter("@DevCode", SqlDbType.NVarChar,50),
					new SqlParameter("@isStop", SqlDbType.Bit,1),
					new SqlParameter("@DayNum", SqlDbType.Int,4),
					new SqlParameter("@StandardValue", SqlDbType.Float,8),
					new SqlParameter("@DayMaxValue", SqlDbType.Float,8),
					new SqlParameter("@DayMinValue", SqlDbType.Float,8),
					new SqlParameter("@ChangeType", SqlDbType.NVarChar,50),
					new SqlParameter("@ChangeRate", SqlDbType.Float,8),
					new SqlParameter("@Multiple", SqlDbType.Decimal,9),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4)};
			parameters[0].Value = model.PointCode;
			parameters[1].Value = model.GeneCode;
			parameters[2].Value = model.DevCode;
			parameters[3].Value = model.isStop;
			parameters[4].Value = model.DayNum;
			parameters[5].Value = model.StandardValue;
			parameters[6].Value = model.DayMaxValue;
			parameters[7].Value = model.DayMinValue;
			parameters[8].Value = model.ChangeType;
			parameters[9].Value = model.ChangeRate;
			parameters[10].Value = model.Multiple;
			parameters[11].Value = model.ExcelServerRCID;
			parameters[12].Value = model.ExcelServerRN;
			parameters[13].Value = model.ExcelServerCN;
			parameters[14].Value = model.ExcelServerRC1;
			parameters[15].Value = model.ExcelServerWIID;
			parameters[16].Value = model.ExcelServerRTID;
			parameters[17].Value = model.ExcelServerCHG;

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
		public bool Update(Maticsoft.Model.T_StationGeneSet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_StationGeneSet set ");
			strSql.Append("PointCode=@PointCode,");
			strSql.Append("GeneCode=@GeneCode,");
			strSql.Append("DevCode=@DevCode,");
			strSql.Append("isStop=@isStop,");
			strSql.Append("DayNum=@DayNum,");
			strSql.Append("StandardValue=@StandardValue,");
			strSql.Append("DayMaxValue=@DayMaxValue,");
			strSql.Append("DayMinValue=@DayMinValue,");
			strSql.Append("ChangeType=@ChangeType,");
			strSql.Append("ChangeRate=@ChangeRate,");
			strSql.Append("Multiple=@Multiple,");
			strSql.Append("ExcelServerRCID=@ExcelServerRCID,");
			strSql.Append("ExcelServerRN=@ExcelServerRN,");
			strSql.Append("ExcelServerCN=@ExcelServerCN,");
			strSql.Append("ExcelServerRC1=@ExcelServerRC1,");
			strSql.Append("ExcelServerWIID=@ExcelServerWIID,");
			strSql.Append("ExcelServerRTID=@ExcelServerRTID,");
			strSql.Append("ExcelServerCHG=@ExcelServerCHG");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@PointCode", SqlDbType.NVarChar,50),
					new SqlParameter("@GeneCode", SqlDbType.NVarChar,50),
					new SqlParameter("@DevCode", SqlDbType.NVarChar,50),
					new SqlParameter("@isStop", SqlDbType.Bit,1),
					new SqlParameter("@DayNum", SqlDbType.Int,4),
					new SqlParameter("@StandardValue", SqlDbType.Float,8),
					new SqlParameter("@DayMaxValue", SqlDbType.Float,8),
					new SqlParameter("@DayMinValue", SqlDbType.Float,8),
					new SqlParameter("@ChangeType", SqlDbType.NVarChar,50),
					new SqlParameter("@ChangeRate", SqlDbType.Float,8),
					new SqlParameter("@Multiple", SqlDbType.Decimal,9),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4)};
			parameters[0].Value = model.PointCode;
			parameters[1].Value = model.GeneCode;
			parameters[2].Value = model.DevCode;
			parameters[3].Value = model.isStop;
			parameters[4].Value = model.DayNum;
			parameters[5].Value = model.StandardValue;
			parameters[6].Value = model.DayMaxValue;
			parameters[7].Value = model.DayMinValue;
			parameters[8].Value = model.ChangeType;
			parameters[9].Value = model.ChangeRate;
			parameters[10].Value = model.Multiple;
			parameters[11].Value = model.ExcelServerRCID;
			parameters[12].Value = model.ExcelServerRN;
			parameters[13].Value = model.ExcelServerCN;
			parameters[14].Value = model.ExcelServerRC1;
			parameters[15].Value = model.ExcelServerWIID;
			parameters[16].Value = model.ExcelServerRTID;
			parameters[17].Value = model.ExcelServerCHG;

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
			strSql.Append("delete from T_StationGeneSet ");
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
		public Maticsoft.Model.T_StationGeneSet GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 PointCode,GeneCode,DevCode,isStop,DayNum,StandardValue,DayMaxValue,DayMinValue,ChangeType,ChangeRate,Multiple,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG from T_StationGeneSet ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.T_StationGeneSet model=new Maticsoft.Model.T_StationGeneSet();
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
		public Maticsoft.Model.T_StationGeneSet DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_StationGeneSet model=new Maticsoft.Model.T_StationGeneSet();
			if (row != null)
			{
				if(row["PointCode"]!=null)
				{
					model.PointCode=row["PointCode"].ToString();
				}
				if(row["GeneCode"]!=null)
				{
					model.GeneCode=row["GeneCode"].ToString();
				}
				if(row["DevCode"]!=null)
				{
					model.DevCode=row["DevCode"].ToString();
				}
				if(row["isStop"]!=null && row["isStop"].ToString()!="")
				{
					if((row["isStop"].ToString()=="1")||(row["isStop"].ToString().ToLower()=="true"))
					{
						model.isStop=true;
					}
					else
					{
						model.isStop=false;
					}
				}
				if(row["DayNum"]!=null && row["DayNum"].ToString()!="")
				{
					model.DayNum=int.Parse(row["DayNum"].ToString());
				}
				if(row["StandardValue"]!=null && row["StandardValue"].ToString()!="")
				{
					model.StandardValue=decimal.Parse(row["StandardValue"].ToString());
				}
				if(row["DayMaxValue"]!=null && row["DayMaxValue"].ToString()!="")
				{
					model.DayMaxValue=decimal.Parse(row["DayMaxValue"].ToString());
				}
				if(row["DayMinValue"]!=null && row["DayMinValue"].ToString()!="")
				{
					model.DayMinValue=decimal.Parse(row["DayMinValue"].ToString());
				}
				if(row["ChangeType"]!=null)
				{
					model.ChangeType=row["ChangeType"].ToString();
				}
				if(row["ChangeRate"]!=null && row["ChangeRate"].ToString()!="")
				{
					model.ChangeRate=decimal.Parse(row["ChangeRate"].ToString());
				}
				if(row["Multiple"]!=null && row["Multiple"].ToString()!="")
				{
					model.Multiple=decimal.Parse(row["Multiple"].ToString());
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
			strSql.Append("select PointCode,GeneCode,DevCode,isStop,DayNum,StandardValue,DayMaxValue,DayMinValue,ChangeType,ChangeRate,Multiple,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG ");
			strSql.Append(" FROM T_StationGeneSet ");
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
			strSql.Append(" PointCode,GeneCode,DevCode,isStop,DayNum,StandardValue,DayMaxValue,DayMinValue,ChangeType,ChangeRate,Multiple,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG ");
			strSql.Append(" FROM T_StationGeneSet ");
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
			strSql.Append("select count(1) FROM T_StationGeneSet ");
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
				strSql.Append("order by T.StationDevID desc");
			}
			strSql.Append(")AS Row, T.*  from T_StationGeneSet T ");
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
			parameters[0].Value = "T_StationGeneSet";
			parameters[1].Value = "StationDevID";
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

