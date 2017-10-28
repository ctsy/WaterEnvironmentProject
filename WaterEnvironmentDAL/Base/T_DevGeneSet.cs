/**  版本信息模板在安装目录下，可自行修改。
* T_DevGeneSet.cs
*
* 功 能： N/A
* 类 名： T_DevGeneSet
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:37   N/A    初版
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
	/// 数据访问类:T_DevGeneSet
	/// </summary>
	public partial class T_DevGeneSet
	{
		public T_DevGeneSet()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.T_DevGeneSet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_DevGeneSet(");
			strSql.Append("PointID,DevCode,GeneID,isStop,DayNum,RangeUp,RangeDown,StandardMaxValue,StandardMinValue,IsJudgeStandard,DayMaxValue,DayMinValue,ChangeType,ChangeRate,DetectionPrinciple,HasZs,HasPf,DecimalPlaces,Sort,RecordFlag,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG)");
			strSql.Append(" values (");
			strSql.Append("@PointID,@DevCode,@GeneID,@isStop,@DayNum,@RangeUp,@RangeDown,@StandardMaxValue,@StandardMinValue,@IsJudgeStandard,@DayMaxValue,@DayMinValue,@ChangeType,@ChangeRate,@DetectionPrinciple,@HasZs,@HasPf,@DecimalPlaces,@Sort,@RecordFlag,@ExcelServerRCID,@ExcelServerRN,@ExcelServerCN,@ExcelServerRC1,@ExcelServerWIID,@ExcelServerRTID,@ExcelServerCHG)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@DevCode", SqlDbType.NVarChar,50),
					new SqlParameter("@GeneID", SqlDbType.Int,4),
					new SqlParameter("@isStop", SqlDbType.Bit,1),
					new SqlParameter("@DayNum", SqlDbType.Int,4),
					new SqlParameter("@RangeUp", SqlDbType.Decimal,9),
					new SqlParameter("@RangeDown", SqlDbType.Decimal,9),
					new SqlParameter("@StandardMaxValue", SqlDbType.Decimal,9),
					new SqlParameter("@StandardMinValue", SqlDbType.Decimal,9),
					new SqlParameter("@IsJudgeStandard", SqlDbType.Bit,1),
					new SqlParameter("@DayMaxValue", SqlDbType.Decimal,9),
					new SqlParameter("@DayMinValue", SqlDbType.Decimal,9),
					new SqlParameter("@ChangeType", SqlDbType.NVarChar,50),
					new SqlParameter("@ChangeRate", SqlDbType.Float,8),
					new SqlParameter("@DetectionPrinciple", SqlDbType.NVarChar,255),
					new SqlParameter("@HasZs", SqlDbType.Bit,1),
					new SqlParameter("@HasPf", SqlDbType.Bit,1),
					new SqlParameter("@DecimalPlaces", SqlDbType.Int,4),
					new SqlParameter("@Sort", SqlDbType.Int,4),
					new SqlParameter("@RecordFlag", SqlDbType.NVarChar,25),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4)};
			parameters[0].Value = model.PointID;
			parameters[1].Value = model.DevCode;
			parameters[2].Value = model.GeneID;
			parameters[3].Value = model.isStop;
			parameters[4].Value = model.DayNum;
			parameters[5].Value = model.RangeUp;
			parameters[6].Value = model.RangeDown;
			parameters[7].Value = model.StandardMaxValue;
			parameters[8].Value = model.StandardMinValue;
			parameters[9].Value = model.IsJudgeStandard;
			parameters[10].Value = model.DayMaxValue;
			parameters[11].Value = model.DayMinValue;
			parameters[12].Value = model.ChangeType;
			parameters[13].Value = model.ChangeRate;
			parameters[14].Value = model.DetectionPrinciple;
			parameters[15].Value = model.HasZs;
			parameters[16].Value = model.HasPf;
			parameters[17].Value = model.DecimalPlaces;
			parameters[18].Value = model.Sort;
			parameters[19].Value = model.RecordFlag;
			parameters[20].Value = model.ExcelServerRCID;
			parameters[21].Value = model.ExcelServerRN;
			parameters[22].Value = model.ExcelServerCN;
			parameters[23].Value = model.ExcelServerRC1;
			parameters[24].Value = model.ExcelServerWIID;
			parameters[25].Value = model.ExcelServerRTID;
			parameters[26].Value = model.ExcelServerCHG;

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
		public bool Update(Maticsoft.Model.T_DevGeneSet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_DevGeneSet set ");
			strSql.Append("PointID=@PointID,");
			strSql.Append("DevCode=@DevCode,");
			strSql.Append("GeneID=@GeneID,");
			strSql.Append("isStop=@isStop,");
			strSql.Append("DayNum=@DayNum,");
			strSql.Append("RangeUp=@RangeUp,");
			strSql.Append("RangeDown=@RangeDown,");
			strSql.Append("StandardMaxValue=@StandardMaxValue,");
			strSql.Append("StandardMinValue=@StandardMinValue,");
			strSql.Append("IsJudgeStandard=@IsJudgeStandard,");
			strSql.Append("DayMaxValue=@DayMaxValue,");
			strSql.Append("DayMinValue=@DayMinValue,");
			strSql.Append("ChangeType=@ChangeType,");
			strSql.Append("ChangeRate=@ChangeRate,");
			strSql.Append("DetectionPrinciple=@DetectionPrinciple,");
			strSql.Append("HasZs=@HasZs,");
			strSql.Append("HasPf=@HasPf,");
			strSql.Append("DecimalPlaces=@DecimalPlaces,");
			strSql.Append("Sort=@Sort,");
			strSql.Append("RecordFlag=@RecordFlag,");
			strSql.Append("ExcelServerRCID=@ExcelServerRCID,");
			strSql.Append("ExcelServerRN=@ExcelServerRN,");
			strSql.Append("ExcelServerCN=@ExcelServerCN,");
			strSql.Append("ExcelServerRC1=@ExcelServerRC1,");
			strSql.Append("ExcelServerWIID=@ExcelServerWIID,");
			strSql.Append("ExcelServerRTID=@ExcelServerRTID,");
			strSql.Append("ExcelServerCHG=@ExcelServerCHG");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@DevCode", SqlDbType.NVarChar,50),
					new SqlParameter("@GeneID", SqlDbType.Int,4),
					new SqlParameter("@isStop", SqlDbType.Bit,1),
					new SqlParameter("@DayNum", SqlDbType.Int,4),
					new SqlParameter("@RangeUp", SqlDbType.Decimal,9),
					new SqlParameter("@RangeDown", SqlDbType.Decimal,9),
					new SqlParameter("@StandardMaxValue", SqlDbType.Decimal,9),
					new SqlParameter("@StandardMinValue", SqlDbType.Decimal,9),
					new SqlParameter("@IsJudgeStandard", SqlDbType.Bit,1),
					new SqlParameter("@DayMaxValue", SqlDbType.Decimal,9),
					new SqlParameter("@DayMinValue", SqlDbType.Decimal,9),
					new SqlParameter("@ChangeType", SqlDbType.NVarChar,50),
					new SqlParameter("@ChangeRate", SqlDbType.Float,8),
					new SqlParameter("@DetectionPrinciple", SqlDbType.NVarChar,255),
					new SqlParameter("@HasZs", SqlDbType.Bit,1),
					new SqlParameter("@HasPf", SqlDbType.Bit,1),
					new SqlParameter("@DecimalPlaces", SqlDbType.Int,4),
					new SqlParameter("@Sort", SqlDbType.Int,4),
					new SqlParameter("@RecordFlag", SqlDbType.NVarChar,25),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.PointID;
			parameters[1].Value = model.DevCode;
			parameters[2].Value = model.GeneID;
			parameters[3].Value = model.isStop;
			parameters[4].Value = model.DayNum;
			parameters[5].Value = model.RangeUp;
			parameters[6].Value = model.RangeDown;
			parameters[7].Value = model.StandardMaxValue;
			parameters[8].Value = model.StandardMinValue;
			parameters[9].Value = model.IsJudgeStandard;
			parameters[10].Value = model.DayMaxValue;
			parameters[11].Value = model.DayMinValue;
			parameters[12].Value = model.ChangeType;
			parameters[13].Value = model.ChangeRate;
			parameters[14].Value = model.DetectionPrinciple;
			parameters[15].Value = model.HasZs;
			parameters[16].Value = model.HasPf;
			parameters[17].Value = model.DecimalPlaces;
			parameters[18].Value = model.Sort;
			parameters[19].Value = model.RecordFlag;
			parameters[20].Value = model.ExcelServerRCID;
			parameters[21].Value = model.ExcelServerRN;
			parameters[22].Value = model.ExcelServerCN;
			parameters[23].Value = model.ExcelServerRC1;
			parameters[24].Value = model.ExcelServerWIID;
			parameters[25].Value = model.ExcelServerRTID;
			parameters[26].Value = model.ExcelServerCHG;
			parameters[27].Value = model.ID;

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
			strSql.Append("delete from T_DevGeneSet ");
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
			strSql.Append("delete from T_DevGeneSet ");
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
		public Maticsoft.Model.T_DevGeneSet GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,PointID,DevCode,GeneID,isStop,DayNum,RangeUp,RangeDown,StandardMaxValue,StandardMinValue,IsJudgeStandard,DayMaxValue,DayMinValue,ChangeType,ChangeRate,DetectionPrinciple,HasZs,HasPf,DecimalPlaces,Sort,RecordFlag,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG from T_DevGeneSet ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Maticsoft.Model.T_DevGeneSet model=new Maticsoft.Model.T_DevGeneSet();
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
		public Maticsoft.Model.T_DevGeneSet DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_DevGeneSet model=new Maticsoft.Model.T_DevGeneSet();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["PointID"]!=null && row["PointID"].ToString()!="")
				{
					model.PointID=int.Parse(row["PointID"].ToString());
				}
				if(row["DevCode"]!=null)
				{
					model.DevCode=row["DevCode"].ToString();
				}
				if(row["GeneID"]!=null && row["GeneID"].ToString()!="")
				{
					model.GeneID=int.Parse(row["GeneID"].ToString());
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
				if(row["RangeUp"]!=null && row["RangeUp"].ToString()!="")
				{
					model.RangeUp=decimal.Parse(row["RangeUp"].ToString());
				}
				if(row["RangeDown"]!=null && row["RangeDown"].ToString()!="")
				{
					model.RangeDown=decimal.Parse(row["RangeDown"].ToString());
				}
				if(row["StandardMaxValue"]!=null && row["StandardMaxValue"].ToString()!="")
				{
					model.StandardMaxValue=decimal.Parse(row["StandardMaxValue"].ToString());
				}
				if(row["StandardMinValue"]!=null && row["StandardMinValue"].ToString()!="")
				{
					model.StandardMinValue=decimal.Parse(row["StandardMinValue"].ToString());
				}
				if(row["IsJudgeStandard"]!=null && row["IsJudgeStandard"].ToString()!="")
				{
					if((row["IsJudgeStandard"].ToString()=="1")||(row["IsJudgeStandard"].ToString().ToLower()=="true"))
					{
						model.IsJudgeStandard=true;
					}
					else
					{
						model.IsJudgeStandard=false;
					}
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
				if(row["DetectionPrinciple"]!=null)
				{
					model.DetectionPrinciple=row["DetectionPrinciple"].ToString();
				}
				if(row["HasZs"]!=null && row["HasZs"].ToString()!="")
				{
					if((row["HasZs"].ToString()=="1")||(row["HasZs"].ToString().ToLower()=="true"))
					{
						model.HasZs=true;
					}
					else
					{
						model.HasZs=false;
					}
				}
				if(row["HasPf"]!=null && row["HasPf"].ToString()!="")
				{
					if((row["HasPf"].ToString()=="1")||(row["HasPf"].ToString().ToLower()=="true"))
					{
						model.HasPf=true;
					}
					else
					{
						model.HasPf=false;
					}
				}
				if(row["DecimalPlaces"]!=null && row["DecimalPlaces"].ToString()!="")
				{
					model.DecimalPlaces=int.Parse(row["DecimalPlaces"].ToString());
				}
				if(row["Sort"]!=null && row["Sort"].ToString()!="")
				{
					model.Sort=int.Parse(row["Sort"].ToString());
				}
				if(row["RecordFlag"]!=null)
				{
					model.RecordFlag=row["RecordFlag"].ToString();
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
			strSql.Append("select ID,PointID,DevCode,GeneID,isStop,DayNum,RangeUp,RangeDown,StandardMaxValue,StandardMinValue,IsJudgeStandard,DayMaxValue,DayMinValue,ChangeType,ChangeRate,DetectionPrinciple,HasZs,HasPf,DecimalPlaces,Sort,RecordFlag,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG ");
			strSql.Append(" FROM T_DevGeneSet ");
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
			strSql.Append(" ID,PointID,DevCode,GeneID,isStop,DayNum,RangeUp,RangeDown,StandardMaxValue,StandardMinValue,IsJudgeStandard,DayMaxValue,DayMinValue,ChangeType,ChangeRate,DetectionPrinciple,HasZs,HasPf,DecimalPlaces,Sort,RecordFlag,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG ");
			strSql.Append(" FROM T_DevGeneSet ");
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
			strSql.Append("select count(1) FROM T_DevGeneSet ");
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
			strSql.Append(")AS Row, T.*  from T_DevGeneSet T ");
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
			parameters[0].Value = "T_DevGeneSet";
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

