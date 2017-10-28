/**  版本信息模板在安装目录下，可自行修改。
* T_SummaryRealdata.cs
*
* 功 能： N/A
* 类 名： T_SummaryRealdata
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/25 14:44:49   N/A    初版
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
	/// 数据访问类:T_SummaryRealdata
	/// </summary>
	public partial class T_SummaryRealdata
	{
		public T_SummaryRealdata()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("PointID", "T_SummaryRealdata"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(DateTime DataTime,int PointID,int GeneID,int DataType)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_SummaryRealdata");
			strSql.Append(" where DataTime=@DataTime and PointID=@PointID and GeneID=@GeneID and DataType=@DataType ");
			SqlParameter[] parameters = {
					new SqlParameter("@DataTime", SqlDbType.DateTime),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@GeneID", SqlDbType.Int,4),
					new SqlParameter("@DataType", SqlDbType.Int,4)			};
			parameters[0].Value = DataTime;
			parameters[1].Value = PointID;
			parameters[2].Value = GeneID;
			parameters[3].Value = DataType;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.T_SummaryRealdata model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_SummaryRealdata(");
			strSql.Append("DataTime,PointID,GeneID,DataType,StateValue,DataValue,DataMaxValue,DataMinValue,DataCouValue,ConvertValue,ConvertMaxValue,ConvertMinValue,WriteTime,DevCode,Person,AuditTime,AbnormalLedger)");
			strSql.Append(" values (");
			strSql.Append("@DataTime,@PointID,@GeneID,@DataType,@StateValue,@DataValue,@DataMaxValue,@DataMinValue,@DataCouValue,@ConvertValue,@ConvertMaxValue,@ConvertMinValue,@WriteTime,@DevCode,@Person,@AuditTime,@AbnormalLedger)");
			SqlParameter[] parameters = {
					new SqlParameter("@DataTime", SqlDbType.DateTime),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@GeneID", SqlDbType.Int,4),
					new SqlParameter("@DataType", SqlDbType.Int,4),
					new SqlParameter("@StateValue", SqlDbType.NVarChar,25),
					new SqlParameter("@DataValue", SqlDbType.Decimal,9),
					new SqlParameter("@DataMaxValue", SqlDbType.Decimal,9),
					new SqlParameter("@DataMinValue", SqlDbType.Decimal,9),
					new SqlParameter("@DataCouValue", SqlDbType.Decimal,9),
					new SqlParameter("@ConvertValue", SqlDbType.Decimal,9),
					new SqlParameter("@ConvertMaxValue", SqlDbType.Decimal,9),
					new SqlParameter("@ConvertMinValue", SqlDbType.Decimal,9),
					new SqlParameter("@WriteTime", SqlDbType.DateTime),
					new SqlParameter("@DevCode", SqlDbType.NVarChar,50),
					new SqlParameter("@Person", SqlDbType.NVarChar,50),
					new SqlParameter("@AuditTime", SqlDbType.DateTime),
					new SqlParameter("@AbnormalLedger", SqlDbType.Int,4)};
			parameters[0].Value = model.DataTime;
			parameters[1].Value = model.PointID;
			parameters[2].Value = model.GeneID;
			parameters[3].Value = model.DataType;
			parameters[4].Value = model.StateValue;
			parameters[5].Value = model.DataValue;
			parameters[6].Value = model.DataMaxValue;
			parameters[7].Value = model.DataMinValue;
			parameters[8].Value = model.DataCouValue;
			parameters[9].Value = model.ConvertValue;
			parameters[10].Value = model.ConvertMaxValue;
			parameters[11].Value = model.ConvertMinValue;
			parameters[12].Value = model.WriteTime;
			parameters[13].Value = model.DevCode;
			parameters[14].Value = model.Person;
			parameters[15].Value = model.AuditTime;
			parameters[16].Value = model.AbnormalLedger;

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
		public bool Update(Maticsoft.Model.T_SummaryRealdata model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_SummaryRealdata set ");
			strSql.Append("StateValue=@StateValue,");
			strSql.Append("DataValue=@DataValue,");
			strSql.Append("DataMaxValue=@DataMaxValue,");
			strSql.Append("DataMinValue=@DataMinValue,");
			strSql.Append("DataCouValue=@DataCouValue,");
			strSql.Append("ConvertValue=@ConvertValue,");
			strSql.Append("ConvertMaxValue=@ConvertMaxValue,");
			strSql.Append("ConvertMinValue=@ConvertMinValue,");
			strSql.Append("WriteTime=@WriteTime,");
			strSql.Append("DevCode=@DevCode,");
			strSql.Append("Person=@Person,");
			strSql.Append("AuditTime=@AuditTime,");
			strSql.Append("AbnormalLedger=@AbnormalLedger");
			strSql.Append(" where DataTime=@DataTime and PointID=@PointID and GeneID=@GeneID and DataType=@DataType ");
			SqlParameter[] parameters = {
					new SqlParameter("@StateValue", SqlDbType.NVarChar,25),
					new SqlParameter("@DataValue", SqlDbType.Decimal,9),
					new SqlParameter("@DataMaxValue", SqlDbType.Decimal,9),
					new SqlParameter("@DataMinValue", SqlDbType.Decimal,9),
					new SqlParameter("@DataCouValue", SqlDbType.Decimal,9),
					new SqlParameter("@ConvertValue", SqlDbType.Decimal,9),
					new SqlParameter("@ConvertMaxValue", SqlDbType.Decimal,9),
					new SqlParameter("@ConvertMinValue", SqlDbType.Decimal,9),
					new SqlParameter("@WriteTime", SqlDbType.DateTime),
					new SqlParameter("@DevCode", SqlDbType.NVarChar,50),
					new SqlParameter("@Person", SqlDbType.NVarChar,50),
					new SqlParameter("@AuditTime", SqlDbType.DateTime),
					new SqlParameter("@AbnormalLedger", SqlDbType.Int,4),
					new SqlParameter("@DataTime", SqlDbType.DateTime),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@GeneID", SqlDbType.Int,4),
					new SqlParameter("@DataType", SqlDbType.Int,4)};
			parameters[0].Value = model.StateValue;
			parameters[1].Value = model.DataValue;
			parameters[2].Value = model.DataMaxValue;
			parameters[3].Value = model.DataMinValue;
			parameters[4].Value = model.DataCouValue;
			parameters[5].Value = model.ConvertValue;
			parameters[6].Value = model.ConvertMaxValue;
			parameters[7].Value = model.ConvertMinValue;
			parameters[8].Value = model.WriteTime;
			parameters[9].Value = model.DevCode;
			parameters[10].Value = model.Person;
			parameters[11].Value = model.AuditTime;
			parameters[12].Value = model.AbnormalLedger;
			parameters[13].Value = model.DataTime;
			parameters[14].Value = model.PointID;
			parameters[15].Value = model.GeneID;
			parameters[16].Value = model.DataType;

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
		public bool Delete(DateTime DataTime,int PointID,int GeneID,int DataType)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_SummaryRealdata ");
			strSql.Append(" where DataTime=@DataTime and PointID=@PointID and GeneID=@GeneID and DataType=@DataType ");
			SqlParameter[] parameters = {
					new SqlParameter("@DataTime", SqlDbType.DateTime),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@GeneID", SqlDbType.Int,4),
					new SqlParameter("@DataType", SqlDbType.Int,4)			};
			parameters[0].Value = DataTime;
			parameters[1].Value = PointID;
			parameters[2].Value = GeneID;
			parameters[3].Value = DataType;

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
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.T_SummaryRealdata GetModel(DateTime DataTime,int PointID,int GeneID,int DataType)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DataTime,PointID,GeneID,DataType,StateValue,DataValue,DataMaxValue,DataMinValue,DataCouValue,ConvertValue,ConvertMaxValue,ConvertMinValue,WriteTime,DevCode,Person,AuditTime,AbnormalLedger from T_SummaryRealdata ");
			strSql.Append(" where DataTime=@DataTime and PointID=@PointID and GeneID=@GeneID and DataType=@DataType ");
			SqlParameter[] parameters = {
					new SqlParameter("@DataTime", SqlDbType.DateTime),
					new SqlParameter("@PointID", SqlDbType.Int,4),
					new SqlParameter("@GeneID", SqlDbType.Int,4),
					new SqlParameter("@DataType", SqlDbType.Int,4)			};
			parameters[0].Value = DataTime;
			parameters[1].Value = PointID;
			parameters[2].Value = GeneID;
			parameters[3].Value = DataType;

			Maticsoft.Model.T_SummaryRealdata model=new Maticsoft.Model.T_SummaryRealdata();
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
		public Maticsoft.Model.T_SummaryRealdata DataRowToModel(DataRow row)
		{
			Maticsoft.Model.T_SummaryRealdata model=new Maticsoft.Model.T_SummaryRealdata();
			if (row != null)
			{
				if(row["DataTime"]!=null && row["DataTime"].ToString()!="")
				{
					model.DataTime=DateTime.Parse(row["DataTime"].ToString());
				}
				if(row["PointID"]!=null && row["PointID"].ToString()!="")
				{
					model.PointID=int.Parse(row["PointID"].ToString());
				}
				if(row["GeneID"]!=null && row["GeneID"].ToString()!="")
				{
					model.GeneID=int.Parse(row["GeneID"].ToString());
				}
				if(row["DataType"]!=null && row["DataType"].ToString()!="")
				{
					model.DataType=int.Parse(row["DataType"].ToString());
				}
				if(row["StateValue"]!=null)
				{
					model.StateValue=row["StateValue"].ToString();
				}
				if(row["DataValue"]!=null && row["DataValue"].ToString()!="")
				{
					model.DataValue=decimal.Parse(row["DataValue"].ToString());
				}
				if(row["DataMaxValue"]!=null && row["DataMaxValue"].ToString()!="")
				{
					model.DataMaxValue=decimal.Parse(row["DataMaxValue"].ToString());
				}
				if(row["DataMinValue"]!=null && row["DataMinValue"].ToString()!="")
				{
					model.DataMinValue=decimal.Parse(row["DataMinValue"].ToString());
				}
				if(row["DataCouValue"]!=null && row["DataCouValue"].ToString()!="")
				{
					model.DataCouValue=decimal.Parse(row["DataCouValue"].ToString());
				}
				if(row["ConvertValue"]!=null && row["ConvertValue"].ToString()!="")
				{
					model.ConvertValue=decimal.Parse(row["ConvertValue"].ToString());
				}
				if(row["ConvertMaxValue"]!=null && row["ConvertMaxValue"].ToString()!="")
				{
					model.ConvertMaxValue=decimal.Parse(row["ConvertMaxValue"].ToString());
				}
				if(row["ConvertMinValue"]!=null && row["ConvertMinValue"].ToString()!="")
				{
					model.ConvertMinValue=decimal.Parse(row["ConvertMinValue"].ToString());
				}
				if(row["WriteTime"]!=null && row["WriteTime"].ToString()!="")
				{
					model.WriteTime=DateTime.Parse(row["WriteTime"].ToString());
				}
				if(row["DevCode"]!=null)
				{
					model.DevCode=row["DevCode"].ToString();
				}
				if(row["Person"]!=null)
				{
					model.Person=row["Person"].ToString();
				}
				if(row["AuditTime"]!=null && row["AuditTime"].ToString()!="")
				{
					model.AuditTime=DateTime.Parse(row["AuditTime"].ToString());
				}
				if(row["AbnormalLedger"]!=null && row["AbnormalLedger"].ToString()!="")
				{
					model.AbnormalLedger=int.Parse(row["AbnormalLedger"].ToString());
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
			strSql.Append("select DataTime,PointID,GeneID,DataType,StateValue,DataValue,DataMaxValue,DataMinValue,DataCouValue,ConvertValue,ConvertMaxValue,ConvertMinValue,WriteTime,DevCode,Person,AuditTime,AbnormalLedger ");
			strSql.Append(" FROM T_SummaryRealdata ");
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
			strSql.Append(" DataTime,PointID,GeneID,DataType,StateValue,DataValue,DataMaxValue,DataMinValue,DataCouValue,ConvertValue,ConvertMaxValue,ConvertMinValue,WriteTime,DevCode,Person,AuditTime,AbnormalLedger ");
			strSql.Append(" FROM T_SummaryRealdata ");
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
			strSql.Append("select count(1) FROM T_SummaryRealdata ");
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
				strSql.Append("order by T.DataType desc");
			}
			strSql.Append(")AS Row, T.*  from T_SummaryRealdata T ");
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
			parameters[0].Value = "T_SummaryRealdata";
			parameters[1].Value = "DataType";
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

