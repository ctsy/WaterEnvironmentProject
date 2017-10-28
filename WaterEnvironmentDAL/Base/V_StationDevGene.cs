/**  版本信息模板在安装目录下，可自行修改。
* V_StationDevGene.cs
*
* 功 能： N/A
* 类 名： V_StationDevGene
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 14:00:19   N/A    初版
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
	/// 数据访问类:V_StationDevGene
	/// </summary>
	public partial class V_StationDevGene
	{
		public V_StationDevGene()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.V_StationDevGene model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into V_StationDevGene(");
			strSql.Append("AreaName,PointID,PointName,MnCode,geneID,genename,unit,geneT212,InstrumentID,InstrumentName,InstrumentModel,InstallDate,DevCode,isStop,DayNum,RangeDown,RangeUp,StandardMinValue,StandardMaxValue,DayMinValue,DayMaxValue,ChangeType,ChangeRate,DetectionPrinciple,HasZs,HasPf,IsJudgeStandard,DecimalPlaces,Sort,PointUses,PointCode)");
			strSql.Append(" values (");
			strSql.Append("@AreaName,@PointID,@PointName,@MnCode,@geneID,@genename,@unit,@geneT212,@InstrumentID,@InstrumentName,@InstrumentModel,@InstallDate,@DevCode,@isStop,@DayNum,@RangeDown,@RangeUp,@StandardMinValue,@StandardMaxValue,@DayMinValue,@DayMaxValue,@ChangeType,@ChangeRate,@DetectionPrinciple,@HasZs,@HasPf,@IsJudgeStandard,@DecimalPlaces,@Sort,@PointUses,@PointCode)");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaName", SqlDbType.NVarChar,255),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@PointName", SqlDbType.NVarChar,255),
					new SqlParameter("@MnCode", SqlDbType.NVarChar,20),
					new SqlParameter("@geneID", SqlDbType.Int,4),
					new SqlParameter("@genename", SqlDbType.NVarChar,255),
					new SqlParameter("@unit", SqlDbType.VarChar,50),
					new SqlParameter("@geneT212", SqlDbType.NVarChar,50),
					new SqlParameter("@InstrumentID", SqlDbType.NVarChar,50),
					new SqlParameter("@InstrumentName", SqlDbType.NVarChar,255),
					new SqlParameter("@InstrumentModel", SqlDbType.NVarChar,50),
					new SqlParameter("@InstallDate", SqlDbType.DateTime),
					new SqlParameter("@DevCode", SqlDbType.NVarChar,50),
					new SqlParameter("@isStop", SqlDbType.Bit,1),
					new SqlParameter("@DayNum", SqlDbType.Int,4),
					new SqlParameter("@RangeDown", SqlDbType.Decimal,9),
					new SqlParameter("@RangeUp", SqlDbType.Decimal,9),
					new SqlParameter("@StandardMinValue", SqlDbType.Decimal,9),
					new SqlParameter("@StandardMaxValue", SqlDbType.Decimal,9),
					new SqlParameter("@DayMinValue", SqlDbType.Decimal,9),
					new SqlParameter("@DayMaxValue", SqlDbType.Decimal,9),
					new SqlParameter("@ChangeType", SqlDbType.NVarChar,50),
					new SqlParameter("@ChangeRate", SqlDbType.Float,8),
					new SqlParameter("@DetectionPrinciple", SqlDbType.NVarChar,255),
					new SqlParameter("@HasZs", SqlDbType.Bit,1),
					new SqlParameter("@HasPf", SqlDbType.Bit,1),
					new SqlParameter("@IsJudgeStandard", SqlDbType.Bit,1),
					new SqlParameter("@DecimalPlaces", SqlDbType.Int,4),
					new SqlParameter("@Sort", SqlDbType.Int,4),
					new SqlParameter("@PointUses", SqlDbType.Bit,1),
					new SqlParameter("@PointCode", SqlDbType.NVarChar,20)};
			parameters[0].Value = model.AreaName;
			parameters[1].Value = model.PointID;
			parameters[2].Value = model.PointName;
			parameters[3].Value = model.MnCode;
			parameters[4].Value = model.geneID;
			parameters[5].Value = model.genename;
			parameters[6].Value = model.unit;
			parameters[7].Value = model.geneT212;
			parameters[8].Value = model.InstrumentID;
			parameters[9].Value = model.InstrumentName;
			parameters[10].Value = model.InstrumentModel;
			parameters[11].Value = model.InstallDate;
			parameters[12].Value = model.DevCode;
			parameters[13].Value = model.isStop;
			parameters[14].Value = model.DayNum;
			parameters[15].Value = model.RangeDown;
			parameters[16].Value = model.RangeUp;
			parameters[17].Value = model.StandardMinValue;
			parameters[18].Value = model.StandardMaxValue;
			parameters[19].Value = model.DayMinValue;
			parameters[20].Value = model.DayMaxValue;
			parameters[21].Value = model.ChangeType;
			parameters[22].Value = model.ChangeRate;
			parameters[23].Value = model.DetectionPrinciple;
			parameters[24].Value = model.HasZs;
			parameters[25].Value = model.HasPf;
			parameters[26].Value = model.IsJudgeStandard;
			parameters[27].Value = model.DecimalPlaces;
			parameters[28].Value = model.Sort;
			parameters[29].Value = model.PointUses;
			parameters[30].Value = model.PointCode;

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
		public bool Update(Maticsoft.Model.V_StationDevGene model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update V_StationDevGene set ");
			strSql.Append("AreaName=@AreaName,");
			strSql.Append("PointID=@PointID,");
			strSql.Append("PointName=@PointName,");
			strSql.Append("MnCode=@MnCode,");
			strSql.Append("geneID=@geneID,");
			strSql.Append("genename=@genename,");
			strSql.Append("unit=@unit,");
			strSql.Append("geneT212=@geneT212,");
			strSql.Append("InstrumentID=@InstrumentID,");
			strSql.Append("InstrumentName=@InstrumentName,");
			strSql.Append("InstrumentModel=@InstrumentModel,");
			strSql.Append("InstallDate=@InstallDate,");
			strSql.Append("DevCode=@DevCode,");
			strSql.Append("isStop=@isStop,");
			strSql.Append("DayNum=@DayNum,");
			strSql.Append("RangeDown=@RangeDown,");
			strSql.Append("RangeUp=@RangeUp,");
			strSql.Append("StandardMinValue=@StandardMinValue,");
			strSql.Append("StandardMaxValue=@StandardMaxValue,");
			strSql.Append("DayMinValue=@DayMinValue,");
			strSql.Append("DayMaxValue=@DayMaxValue,");
			strSql.Append("ChangeType=@ChangeType,");
			strSql.Append("ChangeRate=@ChangeRate,");
			strSql.Append("DetectionPrinciple=@DetectionPrinciple,");
			strSql.Append("HasZs=@HasZs,");
			strSql.Append("HasPf=@HasPf,");
			strSql.Append("IsJudgeStandard=@IsJudgeStandard,");
			strSql.Append("DecimalPlaces=@DecimalPlaces,");
			strSql.Append("Sort=@Sort,");
			strSql.Append("PointUses=@PointUses,");
			strSql.Append("PointCode=@PointCode");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@AreaName", SqlDbType.NVarChar,255),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@PointName", SqlDbType.NVarChar,255),
					new SqlParameter("@MnCode", SqlDbType.NVarChar,20),
					new SqlParameter("@geneID", SqlDbType.Int,4),
					new SqlParameter("@genename", SqlDbType.NVarChar,255),
					new SqlParameter("@unit", SqlDbType.VarChar,50),
					new SqlParameter("@geneT212", SqlDbType.NVarChar,50),
					new SqlParameter("@InstrumentID", SqlDbType.NVarChar,50),
					new SqlParameter("@InstrumentName", SqlDbType.NVarChar,255),
					new SqlParameter("@InstrumentModel", SqlDbType.NVarChar,50),
					new SqlParameter("@InstallDate", SqlDbType.DateTime),
					new SqlParameter("@DevCode", SqlDbType.NVarChar,50),
					new SqlParameter("@isStop", SqlDbType.Bit,1),
					new SqlParameter("@DayNum", SqlDbType.Int,4),
					new SqlParameter("@RangeDown", SqlDbType.Decimal,9),
					new SqlParameter("@RangeUp", SqlDbType.Decimal,9),
					new SqlParameter("@StandardMinValue", SqlDbType.Decimal,9),
					new SqlParameter("@StandardMaxValue", SqlDbType.Decimal,9),
					new SqlParameter("@DayMinValue", SqlDbType.Decimal,9),
					new SqlParameter("@DayMaxValue", SqlDbType.Decimal,9),
					new SqlParameter("@ChangeType", SqlDbType.NVarChar,50),
					new SqlParameter("@ChangeRate", SqlDbType.Float,8),
					new SqlParameter("@DetectionPrinciple", SqlDbType.NVarChar,255),
					new SqlParameter("@HasZs", SqlDbType.Bit,1),
					new SqlParameter("@HasPf", SqlDbType.Bit,1),
					new SqlParameter("@IsJudgeStandard", SqlDbType.Bit,1),
					new SqlParameter("@DecimalPlaces", SqlDbType.Int,4),
					new SqlParameter("@Sort", SqlDbType.Int,4),
					new SqlParameter("@PointUses", SqlDbType.Bit,1),
					new SqlParameter("@PointCode", SqlDbType.NVarChar,20)};
			parameters[0].Value = model.AreaName;
			parameters[1].Value = model.PointID;
			parameters[2].Value = model.PointName;
			parameters[3].Value = model.MnCode;
			parameters[4].Value = model.geneID;
			parameters[5].Value = model.genename;
			parameters[6].Value = model.unit;
			parameters[7].Value = model.geneT212;
			parameters[8].Value = model.InstrumentID;
			parameters[9].Value = model.InstrumentName;
			parameters[10].Value = model.InstrumentModel;
			parameters[11].Value = model.InstallDate;
			parameters[12].Value = model.DevCode;
			parameters[13].Value = model.isStop;
			parameters[14].Value = model.DayNum;
			parameters[15].Value = model.RangeDown;
			parameters[16].Value = model.RangeUp;
			parameters[17].Value = model.StandardMinValue;
			parameters[18].Value = model.StandardMaxValue;
			parameters[19].Value = model.DayMinValue;
			parameters[20].Value = model.DayMaxValue;
			parameters[21].Value = model.ChangeType;
			parameters[22].Value = model.ChangeRate;
			parameters[23].Value = model.DetectionPrinciple;
			parameters[24].Value = model.HasZs;
			parameters[25].Value = model.HasPf;
			parameters[26].Value = model.IsJudgeStandard;
			parameters[27].Value = model.DecimalPlaces;
			parameters[28].Value = model.Sort;
			parameters[29].Value = model.PointUses;
			parameters[30].Value = model.PointCode;

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
			strSql.Append("delete from V_StationDevGene ");
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
		public Maticsoft.Model.V_StationDevGene GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AreaName,PointID,PointName,MnCode,geneID,genename,unit,geneT212,InstrumentID,InstrumentName,InstrumentModel,InstallDate,DevCode,isStop,DayNum,RangeDown,RangeUp,StandardMinValue,StandardMaxValue,DayMinValue,DayMaxValue,ChangeType,ChangeRate,DetectionPrinciple,HasZs,HasPf,IsJudgeStandard,DecimalPlaces,Sort,PointUses,PointCode from V_StationDevGene ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.V_StationDevGene model=new Maticsoft.Model.V_StationDevGene();
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
		public Maticsoft.Model.V_StationDevGene DataRowToModel(DataRow row)
		{
			Maticsoft.Model.V_StationDevGene model=new Maticsoft.Model.V_StationDevGene();
			if (row != null)
			{
				if(row["AreaName"]!=null)
				{
					model.AreaName=row["AreaName"].ToString();
				}
				if(row["PointID"]!=null && row["PointID"].ToString()!="")
				{
					model.PointID=int.Parse(row["PointID"].ToString());
				}
				if(row["PointName"]!=null)
				{
					model.PointName=row["PointName"].ToString();
				}
				if(row["MnCode"]!=null)
				{
					model.MnCode=row["MnCode"].ToString();
				}
				if(row["geneID"]!=null && row["geneID"].ToString()!="")
				{
					model.geneID=int.Parse(row["geneID"].ToString());
				}
				if(row["genename"]!=null)
				{
					model.genename=row["genename"].ToString();
				}
				if(row["unit"]!=null)
				{
					model.unit=row["unit"].ToString();
				}
				if(row["geneT212"]!=null)
				{
					model.geneT212=row["geneT212"].ToString();
				}
				if(row["InstrumentID"]!=null)
				{
					model.InstrumentID=row["InstrumentID"].ToString();
				}
				if(row["InstrumentName"]!=null)
				{
					model.InstrumentName=row["InstrumentName"].ToString();
				}
				if(row["InstrumentModel"]!=null)
				{
					model.InstrumentModel=row["InstrumentModel"].ToString();
				}
				if(row["InstallDate"]!=null && row["InstallDate"].ToString()!="")
				{
					model.InstallDate=DateTime.Parse(row["InstallDate"].ToString());
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
				if(row["RangeDown"]!=null && row["RangeDown"].ToString()!="")
				{
					model.RangeDown=decimal.Parse(row["RangeDown"].ToString());
				}
				if(row["RangeUp"]!=null && row["RangeUp"].ToString()!="")
				{
					model.RangeUp=decimal.Parse(row["RangeUp"].ToString());
				}
				if(row["StandardMinValue"]!=null && row["StandardMinValue"].ToString()!="")
				{
					model.StandardMinValue=decimal.Parse(row["StandardMinValue"].ToString());
				}
				if(row["StandardMaxValue"]!=null && row["StandardMaxValue"].ToString()!="")
				{
					model.StandardMaxValue=decimal.Parse(row["StandardMaxValue"].ToString());
				}
				if(row["DayMinValue"]!=null && row["DayMinValue"].ToString()!="")
				{
					model.DayMinValue=decimal.Parse(row["DayMinValue"].ToString());
				}
				if(row["DayMaxValue"]!=null && row["DayMaxValue"].ToString()!="")
				{
					model.DayMaxValue=decimal.Parse(row["DayMaxValue"].ToString());
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
				if(row["DecimalPlaces"]!=null && row["DecimalPlaces"].ToString()!="")
				{
					model.DecimalPlaces=int.Parse(row["DecimalPlaces"].ToString());
				}
				if(row["Sort"]!=null && row["Sort"].ToString()!="")
				{
					model.Sort=int.Parse(row["Sort"].ToString());
				}
				if(row["PointUses"]!=null && row["PointUses"].ToString()!="")
				{
					if((row["PointUses"].ToString()=="1")||(row["PointUses"].ToString().ToLower()=="true"))
					{
						model.PointUses=true;
					}
					else
					{
						model.PointUses=false;
					}
				}
				if(row["PointCode"]!=null)
				{
					model.PointCode=row["PointCode"].ToString();
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
			strSql.Append("select AreaName,PointID,PointName,MnCode,geneID,genename,unit,geneT212,InstrumentID,InstrumentName,InstrumentModel,InstallDate,DevCode,isStop,DayNum,RangeDown,RangeUp,StandardMinValue,StandardMaxValue,DayMinValue,DayMaxValue,ChangeType,ChangeRate,DetectionPrinciple,HasZs,HasPf,IsJudgeStandard,DecimalPlaces,Sort,PointUses,PointCode ");
			strSql.Append(" FROM V_StationDevGene ");
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
			strSql.Append(" AreaName,PointID,PointName,MnCode,geneID,genename,unit,geneT212,InstrumentID,InstrumentName,InstrumentModel,InstallDate,DevCode,isStop,DayNum,RangeDown,RangeUp,StandardMinValue,StandardMaxValue,DayMinValue,DayMaxValue,ChangeType,ChangeRate,DetectionPrinciple,HasZs,HasPf,IsJudgeStandard,DecimalPlaces,Sort,PointUses,PointCode ");
			strSql.Append(" FROM V_StationDevGene ");
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
			strSql.Append("select count(1) FROM V_StationDevGene ");
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
			strSql.Append(")AS Row, T.*  from V_StationDevGene T ");
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
			parameters[0].Value = "V_StationDevGene";
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

