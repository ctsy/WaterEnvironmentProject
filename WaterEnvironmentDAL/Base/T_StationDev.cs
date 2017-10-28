/**  版本信息模板在安装目录下，可自行修改。
* T_StationDev.cs
*
* 功 能： N/A
* 类 名： T_StationDev
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:51   N/A    初版
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
	/// 数据访问类:T_StationDev
	/// </summary>
	public partial class T_StationDev
	{
		public T_StationDev()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.T_StationDev model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_StationDev(");
			strSql.Append("InstrumentID,PointCode,InstallDate,DevCode,DetectionPrinciple,RangeLow,RangeUp,Protocol,TransmissionType,DevStatus,Remark,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,RecordFlag,PointID,Processmetermodel,Inputtime,currentsituation)");
			strSql.Append(" values (");
			strSql.Append("@InstrumentID,@PointCode,@InstallDate,@DevCode,@DetectionPrinciple,@RangeLow,@RangeUp,@Protocol,@TransmissionType,@DevStatus,@Remark,@ExcelServerRCID,@ExcelServerRN,@ExcelServerCN,@ExcelServerRC1,@ExcelServerWIID,@ExcelServerRTID,@ExcelServerCHG,@RecordFlag,@PointID,@Processmetermodel,@Inputtime,@currentsituation)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@InstrumentID", SqlDbType.NVarChar,50),
					new SqlParameter("@PointCode", SqlDbType.NVarChar,50),
					new SqlParameter("@InstallDate", SqlDbType.DateTime),
					new SqlParameter("@DevCode", SqlDbType.NVarChar,50),
					new SqlParameter("@DetectionPrinciple", SqlDbType.NVarChar,50),
					new SqlParameter("@RangeLow", SqlDbType.NVarChar,255),
					new SqlParameter("@RangeUp", SqlDbType.NVarChar,255),
					new SqlParameter("@Protocol", SqlDbType.NVarChar,50),
					new SqlParameter("@TransmissionType", SqlDbType.NVarChar,50),
					new SqlParameter("@DevStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@RecordFlag", SqlDbType.NVarChar,25),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@Processmetermodel", SqlDbType.NVarChar,50),
					new SqlParameter("@Inputtime", SqlDbType.DateTime),
					new SqlParameter("@currentsituation", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.InstrumentID;
			parameters[1].Value = model.PointCode;
			parameters[2].Value = model.InstallDate;
			parameters[3].Value = model.DevCode;
			parameters[4].Value = model.DetectionPrinciple;
			parameters[5].Value = model.RangeLow;
			parameters[6].Value = model.RangeUp;
			parameters[7].Value = model.Protocol;
			parameters[8].Value = model.TransmissionType;
			parameters[9].Value = model.DevStatus;
			parameters[10].Value = model.Remark;
			parameters[11].Value = model.ExcelServerRCID;
			parameters[12].Value = model.ExcelServerRN;
			parameters[13].Value = model.ExcelServerCN;
			parameters[14].Value = model.ExcelServerRC1;
			parameters[15].Value = model.ExcelServerWIID;
			parameters[16].Value = model.ExcelServerRTID;
			parameters[17].Value = model.ExcelServerCHG;
			parameters[18].Value = model.RecordFlag;
			parameters[19].Value = model.PointID;
			parameters[20].Value = model.Processmetermodel;
			parameters[21].Value = model.Inputtime;
			parameters[22].Value = model.currentsituation;

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
		public bool Update(Maticsoft.Model.T_StationDev model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_StationDev set ");
			strSql.Append("InstrumentID=@InstrumentID,");
			strSql.Append("PointCode=@PointCode,");
			strSql.Append("InstallDate=@InstallDate,");
			strSql.Append("DevCode=@DevCode,");
			strSql.Append("DetectionPrinciple=@DetectionPrinciple,");
			strSql.Append("RangeLow=@RangeLow,");
			strSql.Append("RangeUp=@RangeUp,");
			strSql.Append("Protocol=@Protocol,");
			strSql.Append("TransmissionType=@TransmissionType,");
			strSql.Append("DevStatus=@DevStatus,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("ExcelServerRCID=@ExcelServerRCID,");
			strSql.Append("ExcelServerRN=@ExcelServerRN,");
			strSql.Append("ExcelServerCN=@ExcelServerCN,");
			strSql.Append("ExcelServerRC1=@ExcelServerRC1,");
			strSql.Append("ExcelServerWIID=@ExcelServerWIID,");
			strSql.Append("ExcelServerRTID=@ExcelServerRTID,");
			strSql.Append("ExcelServerCHG=@ExcelServerCHG,");
			strSql.Append("RecordFlag=@RecordFlag,");
			strSql.Append("PointID=@PointID,");
			strSql.Append("Processmetermodel=@Processmetermodel,");
			strSql.Append("Inputtime=@Inputtime,");
			strSql.Append("currentsituation=@currentsituation");
			strSql.Append(" where StationDevID=@StationDevID");
			SqlParameter[] parameters = {
					new SqlParameter("@InstrumentID", SqlDbType.NVarChar,50),
					new SqlParameter("@PointCode", SqlDbType.NVarChar,50),
					new SqlParameter("@InstallDate", SqlDbType.DateTime),
					new SqlParameter("@DevCode", SqlDbType.NVarChar,50),
					new SqlParameter("@DetectionPrinciple", SqlDbType.NVarChar,50),
					new SqlParameter("@RangeLow", SqlDbType.NVarChar,255),
					new SqlParameter("@RangeUp", SqlDbType.NVarChar,255),
					new SqlParameter("@Protocol", SqlDbType.NVarChar,50),
					new SqlParameter("@TransmissionType", SqlDbType.NVarChar,50),
					new SqlParameter("@DevStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@ExcelServerRCID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerCN", SqlDbType.Int,4),
					new SqlParameter("@ExcelServerRC1", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerWIID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerRTID", SqlDbType.NVarChar,20),
					new SqlParameter("@ExcelServerCHG", SqlDbType.Int,4),
					new SqlParameter("@RecordFlag", SqlDbType.NVarChar,25),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@Processmetermodel", SqlDbType.NVarChar,50),
					new SqlParameter("@Inputtime", SqlDbType.DateTime),
					new SqlParameter("@currentsituation", SqlDbType.NVarChar,50),
					new SqlParameter("@StationDevID", SqlDbType.Int,4)};
			parameters[0].Value = model.InstrumentID;
			parameters[1].Value = model.PointCode;
			parameters[2].Value = model.InstallDate;
			parameters[3].Value = model.DevCode;
			parameters[4].Value = model.DetectionPrinciple;
			parameters[5].Value = model.RangeLow;
			parameters[6].Value = model.RangeUp;
			parameters[7].Value = model.Protocol;
			parameters[8].Value = model.TransmissionType;
			parameters[9].Value = model.DevStatus;
			parameters[10].Value = model.Remark;
			parameters[11].Value = model.ExcelServerRCID;
			parameters[12].Value = model.ExcelServerRN;
			parameters[13].Value = model.ExcelServerCN;
			parameters[14].Value = model.ExcelServerRC1;
			parameters[15].Value = model.ExcelServerWIID;
			parameters[16].Value = model.ExcelServerRTID;
			parameters[17].Value = model.ExcelServerCHG;
			parameters[18].Value = model.RecordFlag;
			parameters[19].Value = model.PointID;
			parameters[20].Value = model.Processmetermodel;
			parameters[21].Value = model.Inputtime;
			parameters[22].Value = model.currentsituation;
			parameters[23].Value = model.StationDevID;

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
		public bool Delete(int StationDevID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_StationDev ");
			strSql.Append(" where StationDevID=@StationDevID");
			SqlParameter[] parameters = {
					new SqlParameter("@StationDevID", SqlDbType.Int,4)
			};
			parameters[0].Value = StationDevID;

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
		public bool DeleteList(string StationDevIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_StationDev ");
			strSql.Append(" where StationDevID in ("+StationDevIDlist + ")  ");
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
		public Maticsoft.Model.T_StationDev GetModel(int StationDevID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 InstrumentID,PointCode,InstallDate,DevCode,DetectionPrinciple,RangeLow,RangeUp,Protocol,TransmissionType,DevStatus,Remark,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,StationDevID,RecordFlag,PointID,Processmetermodel,Inputtime,currentsituation from T_StationDev ");
			strSql.Append(" where StationDevID=@StationDevID");
			SqlParameter[] parameters = {
					new SqlParameter("@StationDevID", SqlDbType.Int,4)
			};
			parameters[0].Value = StationDevID;

			Maticsoft.Model.T_StationDev model=new Maticsoft.Model.T_StationDev();
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
		public Maticsoft.Model.T_StationDev DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_StationDev model=new Maticsoft.Model.T_StationDev();
			if (row != null)
			{
				if(row["InstrumentID"]!=null)
				{
					model.InstrumentID=row["InstrumentID"].ToString();
				}
				if(row["PointCode"]!=null)
				{
					model.PointCode=row["PointCode"].ToString();
				}
				if(row["InstallDate"]!=null && row["InstallDate"].ToString()!="")
				{
					model.InstallDate=DateTime.Parse(row["InstallDate"].ToString());
				}
				if(row["DevCode"]!=null)
				{
					model.DevCode=row["DevCode"].ToString();
				}
				if(row["DetectionPrinciple"]!=null)
				{
					model.DetectionPrinciple=row["DetectionPrinciple"].ToString();
				}
				if(row["RangeLow"]!=null)
				{
					model.RangeLow=row["RangeLow"].ToString();
				}
				if(row["RangeUp"]!=null)
				{
					model.RangeUp=row["RangeUp"].ToString();
				}
				if(row["Protocol"]!=null)
				{
					model.Protocol=row["Protocol"].ToString();
				}
				if(row["TransmissionType"]!=null)
				{
					model.TransmissionType=row["TransmissionType"].ToString();
				}
				if(row["DevStatus"]!=null)
				{
					model.DevStatus=row["DevStatus"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
				if(row["StationDevID"]!=null && row["StationDevID"].ToString()!="")
				{
					model.StationDevID=int.Parse(row["StationDevID"].ToString());
				}
				if(row["RecordFlag"]!=null)
				{
					model.RecordFlag=row["RecordFlag"].ToString();
				}
				if(row["PointID"]!=null && row["PointID"].ToString()!="")
				{
					model.PointID=int.Parse(row["PointID"].ToString());
				}
				if(row["Processmetermodel"]!=null)
				{
					model.Processmetermodel=row["Processmetermodel"].ToString();
				}
				if(row["Inputtime"]!=null && row["Inputtime"].ToString()!="")
				{
					model.Inputtime=DateTime.Parse(row["Inputtime"].ToString());
				}
				if(row["currentsituation"]!=null)
				{
					model.currentsituation=row["currentsituation"].ToString();
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
			strSql.Append("select InstrumentID,PointCode,InstallDate,DevCode,DetectionPrinciple,RangeLow,RangeUp,Protocol,TransmissionType,DevStatus,Remark,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,StationDevID,RecordFlag,PointID,Processmetermodel,Inputtime,currentsituation ");
			strSql.Append(" FROM T_StationDev ");
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
			strSql.Append(" InstrumentID,PointCode,InstallDate,DevCode,DetectionPrinciple,RangeLow,RangeUp,Protocol,TransmissionType,DevStatus,Remark,ExcelServerRCID,ExcelServerRN,ExcelServerCN,ExcelServerRC1,ExcelServerWIID,ExcelServerRTID,ExcelServerCHG,StationDevID,RecordFlag,PointID,Processmetermodel,Inputtime,currentsituation ");
			strSql.Append(" FROM T_StationDev ");
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
			strSql.Append("select count(1) FROM T_StationDev ");
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
			strSql.Append(")AS Row, T.*  from T_StationDev T ");
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
			parameters[0].Value = "T_StationDev";
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

