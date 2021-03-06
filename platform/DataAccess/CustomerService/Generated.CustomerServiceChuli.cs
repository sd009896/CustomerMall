﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Web.Script.Serialization;
using Foresight.DataAccess.Framework;


namespace Foresight.DataAccess
{
	/// <summary>
	/// This object represents the properties and methods of a CustomerServiceChuli.
	/// </summary>
	[Serializable()]
	[DebuggerDisplay("ID: {ID}")]
	public partial class CustomerServiceChuli 
	{
		#region Public Properties
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _iD = int.MinValue;
		/// <summary>
		/// 
		/// </summary>
        [Description("")]
		[DatabaseColumn()]
		[TypeConverter(typeof(MinToEmptyTypeConverter))]
		[DataObjectField(true, true, false)]
		public int ID
		{
			[DebuggerStepThrough()]
			get { return this._iD; }
			 set 
			{
				if (this._iD != value) 
				{
					this._iD = value;
					this.IsDirty = true;	
					OnPropertyChanged("ID");
				}
			}
		}
		
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _serviceID = int.MinValue;
		/// <summary>
		/// 
		/// </summary>
        [Description("")]
		[DatabaseColumn()]
		[TypeConverter(typeof(MinToEmptyTypeConverter))]
		[DataObjectField(false, false, false)]
		public int ServiceID
		{
			[DebuggerStepThrough()]
			get { return this._serviceID; }
			set 
			{
				if (this._serviceID != value) 
				{
					this._serviceID = value;
					this.IsDirty = true;	
					OnPropertyChanged("ServiceID");
				}
			}
		}
		
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DateTime _chuliDate = DateTime.MinValue;
		/// <summary>
		/// 
		/// </summary>
        [Description("")]
		[DatabaseColumn()]
		[TypeConverter(typeof(MinToEmptyTypeConverter))]
		[DataObjectField(false, false, true)]
		public DateTime ChuliDate
		{
			[DebuggerStepThrough()]
			get { return this._chuliDate; }
			set 
			{
				if (this._chuliDate != value) 
				{
					this._chuliDate = value;
					this.IsDirty = true;	
					OnPropertyChanged("ChuliDate");
				}
			}
		}
		
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _chuliNote = String.Empty;
		/// <summary>
		/// 
		/// </summary>
        [Description("")]
		[DatabaseColumn()]
		[TypeConverter(typeof(MinToEmptyTypeConverter))]
		[DataObjectField(false, false, true)]
		public string ChuliNote
		{
			[DebuggerStepThrough()]
			get { return this._chuliNote; }
			set 
			{
				if (this._chuliNote != value) 
				{
					this._chuliNote = value;
					this.IsDirty = true;	
					OnPropertyChanged("ChuliNote");
				}
			}
		}
		
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DateTime _addTime = DateTime.MinValue;
		/// <summary>
		/// 
		/// </summary>
        [Description("")]
		[DatabaseColumn()]
		[TypeConverter(typeof(MinToEmptyTypeConverter))]
		[DataObjectField(false, false, true)]
		public DateTime AddTime
		{
			[DebuggerStepThrough()]
			get { return this._addTime; }
			set 
			{
				if (this._addTime != value) 
				{
					this._addTime = value;
					this.IsDirty = true;	
					OnPropertyChanged("AddTime");
				}
			}
		}
		
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private decimal _handelFee = decimal.MinValue;
		/// <summary>
		/// 
		/// </summary>
        [Description("")]
		[DatabaseColumn()]
		[TypeConverter(typeof(MinToEmptyTypeConverter))]
		[DataObjectField(false, false, true)]
		public decimal HandelFee
		{
			[DebuggerStepThrough()]
			get { return this._handelFee; }
			set 
			{
				if (this._handelFee != value) 
				{
					this._handelFee = value;
					this.IsDirty = true;	
					OnPropertyChanged("HandelFee");
				}
			}
		}
		
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private decimal _otherFee = decimal.MinValue;
		/// <summary>
		/// 
		/// </summary>
        [Description("")]
		[DatabaseColumn()]
		[TypeConverter(typeof(MinToEmptyTypeConverter))]
		[DataObjectField(false, false, true)]
		public decimal OtherFee
		{
			[DebuggerStepThrough()]
			get { return this._otherFee; }
			set 
			{
				if (this._otherFee != value) 
				{
					this._otherFee = value;
					this.IsDirty = true;	
					OnPropertyChanged("OtherFee");
				}
			}
		}
		
		
		
		#endregion
		
		#region Non-Public Properties
		/// <summary>
		/// Gets the SQL statement for an insert
		/// </summary>
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected override string InsertSqlStatement
		{
			[DebuggerStepThrough()]
			get 
			{
				return @"
DECLARE @table TABLE(
	[ID] int,
	[ServiceID] int,
	[ChuliDate] datetime,
	[ChuliNote] ntext,
	[AddTime] datetime,
	[HandelFee] decimal(18, 2),
	[OtherFee] decimal(18, 2)
);

INSERT INTO [dbo].[CustomerServiceChuli] (
	[CustomerServiceChuli].[ServiceID],
	[CustomerServiceChuli].[ChuliDate],
	[CustomerServiceChuli].[ChuliNote],
	[CustomerServiceChuli].[AddTime],
	[CustomerServiceChuli].[HandelFee],
	[CustomerServiceChuli].[OtherFee]
) 
output 
	INSERTED.[ID],
	INSERTED.[ServiceID],
	INSERTED.[ChuliDate],
	INSERTED.[ChuliNote],
	INSERTED.[AddTime],
	INSERTED.[HandelFee],
	INSERTED.[OtherFee]
into @table
VALUES ( 
	@ServiceID,
	@ChuliDate,
	@ChuliNote,
	@AddTime,
	@HandelFee,
	@OtherFee 
); 

SELECT 
	[ID],
	[ServiceID],
	[ChuliDate],
	[ChuliNote],
	[AddTime],
	[HandelFee],
	[OtherFee] 
FROM @table;
";
			}
		}
		
		/// <summary>
		/// Gets the SQL statement for an update by key
		/// </summary>
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected override string UpdateSqlStatement
		{
			[DebuggerStepThrough()]
			get
			{
				return @"
DECLARE @table TABLE(
	[ID] int,
	[ServiceID] int,
	[ChuliDate] datetime,
	[ChuliNote] ntext,
	[AddTime] datetime,
	[HandelFee] decimal(18, 2),
	[OtherFee] decimal(18, 2)
);

UPDATE [dbo].[CustomerServiceChuli] SET 
	[CustomerServiceChuli].[ServiceID] = @ServiceID,
	[CustomerServiceChuli].[ChuliDate] = @ChuliDate,
	[CustomerServiceChuli].[ChuliNote] = @ChuliNote,
	[CustomerServiceChuli].[AddTime] = @AddTime,
	[CustomerServiceChuli].[HandelFee] = @HandelFee,
	[CustomerServiceChuli].[OtherFee] = @OtherFee 
output 
	INSERTED.[ID],
	INSERTED.[ServiceID],
	INSERTED.[ChuliDate],
	INSERTED.[ChuliNote],
	INSERTED.[AddTime],
	INSERTED.[HandelFee],
	INSERTED.[OtherFee]
into @table
WHERE 
	[CustomerServiceChuli].[ID] = @ID

SELECT 
	[ID],
	[ServiceID],
	[ChuliDate],
	[ChuliNote],
	[AddTime],
	[HandelFee],
	[OtherFee] 
FROM @table;
";
			}
		}
		
		/// <summary>
		/// Gets the SQL statement for a delete by key
		/// </summary>
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected override string DeleteSqlStatement
		{
			[DebuggerStepThrough()]
			get
			{
				return @"
DELETE FROM [dbo].[CustomerServiceChuli]
WHERE 
	[CustomerServiceChuli].[ID] = @ID";	
			}
		}
		#endregion
		
		#region Constructors
		/// <summary>
		/// The default protected constructor
		/// </summary>
		public CustomerServiceChuli() { }
		#endregion
		
		#region Public Methods
		

        /// <summary>
        /// Refreshes the entity with data from the data source. Child entity objects and entity list objects will be preserved (ie. they will not be replaced with new objects so that references to them are retained, such as bound data controls).
        /// </summary>
        public override void Refresh()
		{
			this.Replace(GetCustomerServiceChuli(this.ID));
		}

		#endregion
		
		#region Non-Public Methods
		/// <summary>
		/// This is called before an entity is saved to ensure that any parent entities keys are set properly
		/// </summary>
		protected override void EnsureParentProperties()
		{
		}
		#endregion
		
		#region Static Properties
		/// <summary>
		/// A list of all fields for this entity in the database. It does not include the 
		/// select keyword, or the table information - just the fields. This can be used
		/// for new dynamic methods.
		/// </summary>
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static string SelectFieldList 
		{
			get 
			{
				return @"
	[CustomerServiceChuli].[ID],
	[CustomerServiceChuli].[ServiceID],
	[CustomerServiceChuli].[ChuliDate],
	[CustomerServiceChuli].[ChuliNote],
	[CustomerServiceChuli].[AddTime],
	[CustomerServiceChuli].[HandelFee],
	[CustomerServiceChuli].[OtherFee]
";
			}
		}
		
		
		/// <summary>
        /// Table Name
        /// </summary>
        public new static string TableName
        {
            get
            {
                return "CustomerServiceChuli";
            }
        }

		#endregion
		
		#region Static Methods
		/// <summary>
		/// Insert a CustomerServiceChuli into the data store based on the primitive properties. This can be used as the 
		/// insert method for an ObjectDataSource.
		/// </summary>
		/// <param name="serviceID">serviceID</param>
		/// <param name="chuliDate">chuliDate</param>
		/// <param name="chuliNote">chuliNote</param>
		/// <param name="addTime">addTime</param>
		/// <param name="handelFee">handelFee</param>
		/// <param name="otherFee">otherFee</param>
		public static void InsertCustomerServiceChuli(int @serviceID, DateTime @chuliDate, string @chuliNote, DateTime @addTime, decimal @handelFee, decimal @otherFee)
		{
            using (SqlHelper helper = new SqlHelper())
            {
                try
                {
                    helper.BeginTransaction();
            		InsertCustomerServiceChuli(@serviceID, @chuliDate, @chuliNote, @addTime, @handelFee, @otherFee, helper);
                    helper.Commit();
                }
                catch
                {
                    helper.Rollback();
                    throw;
                }
            }
		}

		/// <summary>
		/// Insert a CustomerServiceChuli into the data store based on the primitive properties. This can be used as the 
		/// insert method for an ObjectDataSource.
		/// </summary>
		/// <param name="serviceID">serviceID</param>
		/// <param name="chuliDate">chuliDate</param>
		/// <param name="chuliNote">chuliNote</param>
		/// <param name="addTime">addTime</param>
		/// <param name="handelFee">handelFee</param>
		/// <param name="otherFee">otherFee</param>
		/// <param name="helper">helper</param>
		internal static void InsertCustomerServiceChuli(int @serviceID, DateTime @chuliDate, string @chuliNote, DateTime @addTime, decimal @handelFee, decimal @otherFee, SqlHelper @helper)
		{
			string commandText = @"
DECLARE @table TABLE(
	[ID] int,
	[ServiceID] int,
	[ChuliDate] datetime,
	[ChuliNote] ntext,
	[AddTime] datetime,
	[HandelFee] decimal(18, 2),
	[OtherFee] decimal(18, 2)
);

INSERT INTO [dbo].[CustomerServiceChuli] (
	[CustomerServiceChuli].[ServiceID],
	[CustomerServiceChuli].[ChuliDate],
	[CustomerServiceChuli].[ChuliNote],
	[CustomerServiceChuli].[AddTime],
	[CustomerServiceChuli].[HandelFee],
	[CustomerServiceChuli].[OtherFee]
) 
output 
	INSERTED.[ID],
	INSERTED.[ServiceID],
	INSERTED.[ChuliDate],
	INSERTED.[ChuliNote],
	INSERTED.[AddTime],
	INSERTED.[HandelFee],
	INSERTED.[OtherFee]
into @table
VALUES ( 
	@ServiceID,
	@ChuliDate,
	@ChuliNote,
	@AddTime,
	@HandelFee,
	@OtherFee 
); 

SELECT 
	[ID],
	[ServiceID],
	[ChuliDate],
	[ChuliNote],
	[AddTime],
	[HandelFee],
	[OtherFee] 
FROM @table;
";
			
			System.Collections.Generic.List<SqlParameter> parameters = new System.Collections.Generic.List<SqlParameter>();
			parameters.Add(new SqlParameter("@ServiceID", EntityBase.GetDatabaseValue(@serviceID)));
			parameters.Add(new SqlParameter("@ChuliDate", EntityBase.GetDatabaseValue(@chuliDate)));
			parameters.Add(new SqlParameter("@ChuliNote", EntityBase.GetDatabaseValue(@chuliNote)));
			parameters.Add(new SqlParameter("@AddTime", EntityBase.GetDatabaseValue(@addTime)));
			parameters.Add(new SqlParameter("@HandelFee", EntityBase.GetDatabaseValue(@handelFee)));
			parameters.Add(new SqlParameter("@OtherFee", EntityBase.GetDatabaseValue(@otherFee)));
			
			@helper.Execute(commandText, CommandType.Text, parameters);
		}
		
		/// <summary>
		/// Updates a CustomerServiceChuli into the data store based on the primitive properties. This can be used as the 
		/// update method for an ObjectDataSource.
		/// </summary>
		/// <param name="iD">iD</param>
		/// <param name="serviceID">serviceID</param>
		/// <param name="chuliDate">chuliDate</param>
		/// <param name="chuliNote">chuliNote</param>
		/// <param name="addTime">addTime</param>
		/// <param name="handelFee">handelFee</param>
		/// <param name="otherFee">otherFee</param>
		public static void UpdateCustomerServiceChuli(int @iD, int @serviceID, DateTime @chuliDate, string @chuliNote, DateTime @addTime, decimal @handelFee, decimal @otherFee)
		{
			using (SqlHelper helper = new SqlHelper()) 
			{
				try
				{
					helper.BeginTransaction();
					UpdateCustomerServiceChuli(@iD, @serviceID, @chuliDate, @chuliNote, @addTime, @handelFee, @otherFee, helper);
					helper.Commit();
				}
				catch 
				{
					helper.Rollback();	
					throw;
				}
			}
		}
		
		/// <summary>
		/// Updates a CustomerServiceChuli into the data store based on the primitive properties. This can be used as the 
		/// update method for an ObjectDataSource.
		/// </summary>
		/// <param name="iD">iD</param>
		/// <param name="serviceID">serviceID</param>
		/// <param name="chuliDate">chuliDate</param>
		/// <param name="chuliNote">chuliNote</param>
		/// <param name="addTime">addTime</param>
		/// <param name="handelFee">handelFee</param>
		/// <param name="otherFee">otherFee</param>
		/// <param name="helper">helper</param>
		internal static void UpdateCustomerServiceChuli(int @iD, int @serviceID, DateTime @chuliDate, string @chuliNote, DateTime @addTime, decimal @handelFee, decimal @otherFee, SqlHelper @helper)
		{
			string commandText = @"
DECLARE @table TABLE(
	[ID] int,
	[ServiceID] int,
	[ChuliDate] datetime,
	[ChuliNote] ntext,
	[AddTime] datetime,
	[HandelFee] decimal(18, 2),
	[OtherFee] decimal(18, 2)
);

UPDATE [dbo].[CustomerServiceChuli] SET 
	[CustomerServiceChuli].[ServiceID] = @ServiceID,
	[CustomerServiceChuli].[ChuliDate] = @ChuliDate,
	[CustomerServiceChuli].[ChuliNote] = @ChuliNote,
	[CustomerServiceChuli].[AddTime] = @AddTime,
	[CustomerServiceChuli].[HandelFee] = @HandelFee,
	[CustomerServiceChuli].[OtherFee] = @OtherFee 
output 
	INSERTED.[ID],
	INSERTED.[ServiceID],
	INSERTED.[ChuliDate],
	INSERTED.[ChuliNote],
	INSERTED.[AddTime],
	INSERTED.[HandelFee],
	INSERTED.[OtherFee]
into @table
WHERE 
	[CustomerServiceChuli].[ID] = @ID

SELECT 
	[ID],
	[ServiceID],
	[ChuliDate],
	[ChuliNote],
	[AddTime],
	[HandelFee],
	[OtherFee] 
FROM @table;
";
			
			System.Collections.Generic.List<SqlParameter> parameters = new System.Collections.Generic.List<SqlParameter>();
			parameters.Add(new SqlParameter("@ID", EntityBase.GetDatabaseValue(@iD)));
			parameters.Add(new SqlParameter("@ServiceID", EntityBase.GetDatabaseValue(@serviceID)));
			parameters.Add(new SqlParameter("@ChuliDate", EntityBase.GetDatabaseValue(@chuliDate)));
			parameters.Add(new SqlParameter("@ChuliNote", EntityBase.GetDatabaseValue(@chuliNote)));
			parameters.Add(new SqlParameter("@AddTime", EntityBase.GetDatabaseValue(@addTime)));
			parameters.Add(new SqlParameter("@HandelFee", EntityBase.GetDatabaseValue(@handelFee)));
			parameters.Add(new SqlParameter("@OtherFee", EntityBase.GetDatabaseValue(@otherFee)));
			
			@helper.Execute(commandText, CommandType.Text, parameters);
		}
		
		/// <summary>
		/// Deletes a CustomerServiceChuli from the data store based on the primitive primary keys. This can be used as the 
		/// delete method for an ObjectDataSource.
		/// </summary>
		/// <param name="iD">iD</param>
		public static void DeleteCustomerServiceChuli(int @iD)
		{
			using (SqlHelper helper = new SqlHelper()) 
			{
				try 
				{
					helper.BeginTransaction();
					DeleteCustomerServiceChuli(@iD, helper);
					helper.Commit();
				} 
				catch 
				{
					helper.Rollback();
					throw;
				}
			}
		}
		
		/// <summary>
		/// Deletes a CustomerServiceChuli from the data store based on the primitive primary keys. This can be used as the 
		/// delete method for an ObjectDataSource.
		/// </summary>
		/// <param name="iD">iD</param>
		/// <param name="helper">helper</param>
		internal static void DeleteCustomerServiceChuli(int @iD, SqlHelper @helper)
		{
			string commandText = @"
DELETE FROM [dbo].[CustomerServiceChuli]
WHERE 
	[CustomerServiceChuli].[ID] = @ID";
			
			System.Collections.Generic.List<SqlParameter> parameters = new System.Collections.Generic.List<SqlParameter>();
			parameters.Add(new SqlParameter("@ID", @iD));
		
			@helper.Execute(commandText, CommandType.Text, parameters);
		}
		
		/// <summary>
		/// Creates a new CustomerServiceChuli object.
		/// </summary>
		/// <returns>The newly created CustomerServiceChuli object.</returns>
		public static CustomerServiceChuli CreateCustomerServiceChuli()
		{
			return InitializeNew<CustomerServiceChuli>();
		}
		
		/// <summary>
		/// Retrieve information for a CustomerServiceChuli by a CustomerServiceChuli's unique identifier.
		/// </summary>
		/// <param name="iD">iD</param>
		/// <returns>CustomerServiceChuli</returns>
		public static CustomerServiceChuli GetCustomerServiceChuli(int @iD)
		{
			string commandText = @"
SELECT 
" + CustomerServiceChuli.SelectFieldList + @"
FROM [dbo].[CustomerServiceChuli] 
WHERE 
	[CustomerServiceChuli].[ID] = @ID " + CustomerServiceChuli.DefaultSortOrder;
			
			System.Collections.Generic.List<SqlParameter> parameters = new System.Collections.Generic.List<SqlParameter>();
			parameters.Add(new SqlParameter("@ID", @iD));
			
			return GetOne<CustomerServiceChuli>(commandText, parameters);
		}
        
        /// <summary>
		/// Retrieve information for a CustomerServiceChuli by a CustomerServiceChuli's unique identifier.
		/// </summary>
		/// <param name="iD">iD</param>
        /// <param name="helper">SqlHelper</param>
		/// <returns>CustomerServiceChuli</returns>
		public static CustomerServiceChuli GetCustomerServiceChuli(int @iD, SqlHelper @helper)
		{
			string commandText = @"
SELECT 
" + CustomerServiceChuli.SelectFieldList + @"
FROM [dbo].[CustomerServiceChuli] 
WHERE 
	[CustomerServiceChuli].[ID] = @ID " + CustomerServiceChuli.DefaultSortOrder;
			
			System.Collections.Generic.List<SqlParameter> parameters = new System.Collections.Generic.List<SqlParameter>();
			parameters.Add(new SqlParameter("@ID", @iD));
			
			return GetOne<CustomerServiceChuli>(commandText, parameters, @helper);
		}
		
		/// <summary>
		/// Gets a collection CustomerServiceChuli objects.
		/// </summary>
		/// <returns>The retrieved collection of CustomerServiceChuli objects.</returns>
		public static EntityList<CustomerServiceChuli> GetCustomerServiceChulis()
		{
			string commandText = @"
SELECT " + CustomerServiceChuli.SelectFieldList + "FROM [dbo].[CustomerServiceChuli] " + CustomerServiceChuli.DefaultSortOrder;
		
			System.Collections.Generic.List<SqlParameter> parameters = new System.Collections.Generic.List<SqlParameter>();
			
			return GetList<CustomerServiceChuli>(commandText, parameters);
		}
		
		/// <summary>
        /// Gets a collection CustomerServiceChuli objects.
        /// </summary>
		/// <param name="orderBy">order by</param>
		/// <param name="startRowIndex">Start Row Index</param>
		/// <param name="pageSize">PageSize</param>
		/// <param name="totalRows">Total rows</param>
        /// <returns>The retrieved collection of CustomerServiceChuli objects.</returns>
        public static EntityList<CustomerServiceChuli> GetCustomerServiceChulis(string orderBy, int startRowIndex, int pageSize, out long totalRows)
        {
            return GetList<CustomerServiceChuli>(SelectFieldList, "FROM [dbo].[CustomerServiceChuli]", new List<SqlParameter>(),orderBy,  startRowIndex, pageSize, out totalRows);
        }

		/// <summary>
        /// Gets a collection CustomerServiceChuli objects.
        /// </summary>
		/// <param name="startRowIndex">Start Row Index</param>
		/// <param name="pageSize">Page Size</param>
		/// <param name="totalRows">Total rows</param>
        /// <returns>The retrieved collection of CustomerServiceChuli objects.</returns>
        public static EntityList<CustomerServiceChuli> GetCustomerServiceChulis(int startRowIndex, int pageSize, out long totalRows)
        {
            return GetList<CustomerServiceChuli>(SelectFieldList, "FROM [dbo].[CustomerServiceChuli]", new List<SqlParameter>(), null,  startRowIndex, pageSize, out totalRows);
        }
		
		/// <summary>
		/// Gets a collection CustomerServiceChuli objects by custom where clause.
		/// </summary>
		/// <param name="where">The where clause to use for the query. Should be parameterized and start with "where"</param>
		/// <param name="parameter">The parameter that is in the where clause</param>
		/// <param name="orderBy">the order by clause. Should start with "order by"</param>
		/// <returns>The retrieved collection of CustomerServiceChuli objects.</returns>
		protected static EntityList<CustomerServiceChuli> GetCustomerServiceChulis(string where, SqlParameter parameter, string orderBy)
		{
			System.Collections.Generic.List<SqlParameter> parameters = new System.Collections.Generic.List<SqlParameter>();
			
			parameters.Add(parameter);
						
			return GetCustomerServiceChulis(string.Empty, where, parameters, orderBy);
		}
		
		/// <summary>
		/// Gets a collection CustomerServiceChuli objects by custom where clause.
		/// </summary>
		/// <param name="where">The where clause to use for the query. Should be parameterized and start with "where"</param>
		/// <param name="parameter">The parameter that is in the where clause</param>
		/// <returns>The retrieved collection of CustomerServiceChuli objects.</returns>
		protected static EntityList<CustomerServiceChuli> GetCustomerServiceChulis(string where, SqlParameter parameter)
		{
			System.Collections.Generic.List<SqlParameter> parameters = new System.Collections.Generic.List<SqlParameter>();
			
			parameters.Add(parameter);
						
			return GetCustomerServiceChulis(string.Empty, where, parameters, CustomerServiceChuli.DefaultSortOrder);
		}
		
		/// <summary>
		/// Gets a collection CustomerServiceChuli objects by custom where clause.
		/// </summary>
		/// <param name="prefix">The prefix clause allows you to inject a distinct or top clause.</param>
		/// <param name="where">The where clause to use for the query. Should be parameterized and start with "where"</param>
		/// <param name="parameter">The parameter that is in the where clause</param>
		/// <returns>The retrieved collection of CustomerServiceChuli objects.</returns>
		protected static EntityList<CustomerServiceChuli> GetCustomerServiceChulis(string prefix, string where, SqlParameter parameter)
		{
			System.Collections.Generic.List<SqlParameter> parameters = new System.Collections.Generic.List<SqlParameter>();
			
			parameters.Add(parameter);
						
			return GetCustomerServiceChulis(prefix, where, parameters, CustomerServiceChuli.DefaultSortOrder);
		}
		
		/// <summary>
		/// Gets a collection CustomerServiceChuli objects by custom where clause.
		/// </summary>
		/// <param name="prefix">The prefix clause allows you to inject a distinct or top clause.</param>
		/// <param name="where">The where clause to use for the query. Should be parameterized and start with "where"</param>
		/// <param name="parameters">The parameters that are listed in the where clause</param>
		/// <returns>The retrieved collection of CustomerServiceChuli objects.</returns>
		protected static EntityList<CustomerServiceChuli> GetCustomerServiceChulis(string where, System.Collections.Generic.List<SqlParameter> parameters)
		{
			return GetCustomerServiceChulis(string.Empty, where, parameters, CustomerServiceChuli.DefaultSortOrder);
		}
		
		/// <summary>
		/// Gets a collection CustomerServiceChuli objects by custom where clause.
		/// </summary>
		/// <param name="prefix">The prefix clause allows you to inject a distinct or top clause.</param>
		/// <param name="where">The where clause to use for the query. Should be parameterized and start with "where"</param>
		/// <param name="parameters">The parameters that are listed in the where clause</param>
		/// <returns>The retrieved collection of CustomerServiceChuli objects.</returns>
		protected static EntityList<CustomerServiceChuli> GetCustomerServiceChulis(string prefix, string where, System.Collections.Generic.List<SqlParameter> parameters)
		{
			return GetCustomerServiceChulis(prefix, where, parameters, CustomerServiceChuli.DefaultSortOrder);
		}
		
		/// <summary>
		/// Gets a collection CustomerServiceChuli objects by custom where clause and order by.
		/// </summary>
		/// <param name="prefix">The prefix clause allows you to inject a distinct or top clause.</param>
		/// <param name="where">The where clause to use for the query. Should be parameterized and start with "where"</param>
		/// <param name="parameters">The parameters that are listed in the where clause</param>
		/// <param name="orderBy">the order by clause. Shoudl start with "order by"</param>
		/// <returns>The retrieved collection of CustomerServiceChuli objects.</returns>
		protected static EntityList<CustomerServiceChuli> GetCustomerServiceChulis(string prefix, string where, System.Collections.Generic.List<SqlParameter> parameters, string orderBy)
		{
			string commandText = @"SELECT " + prefix + "" + CustomerServiceChuli.SelectFieldList + "FROM [dbo].[CustomerServiceChuli] " + where + " " + orderBy;			
			
			using (SqlHelper helper = new SqlHelper()) 
			{
				using (IDataReader reader = helper.ExecuteDataReader(commandText, CommandType.Text, parameters))
				{
					return EntityBase.InitializeList<CustomerServiceChuli>(reader);
				}
			}
		}		
		
		/// <summary>
        /// Gets a collection Address objects.
        /// </summary>
		/// <param name="orderBy">order by</param>
		/// <param name="where">where</param>
		/// <param name=parameters">parameters</param>
		/// <param name="startRowIndex">Start Row Index</param>
		/// <param name="pageSize">PageSize</param>
		/// <param name="totalRows">Total rows</param>
        /// <returns>The retrieved collection of Address objects.</returns>
        protected static EntityList<CustomerServiceChuli> GetCustomerServiceChulis(string orderBy, string where, System.Collections.Generic.List<SqlParameter> parameters, int startRowIndex, int pageSize, out long totalRows)
        {
            return GetList<CustomerServiceChuli>(SelectFieldList, "FROM [dbo].[CustomerServiceChuli] " + where, parameters, orderBy, startRowIndex, pageSize, out totalRows);			
		}
		
        
        /// <summary>
        /// Gets Total Count of CustomerServiceChuli objects
        /// </summary>
        /// <returns>The count of Customer objects.</returns>
        public static long GetCustomerServiceChuliCount()
        {
            return GetCustomerServiceChuliCount(string.Empty,new System.Collections.Generic.List<SqlParameter>());
        }

        /// <summary>
        /// Gets Total Count of CustomerServiceChuli objects by custom where clause.
        /// </summary>
        /// <param name="where">The where clause to use for the query. Should be parameterized and start with "where"</param>
        /// <param name="parameters">The parameters that are listed in the where clause</param>
        /// <returns>The count of Customer objects.</returns>
        public static long GetCustomerServiceChuliCount(string where, System.Collections.Generic.List<SqlParameter> parameters)
        {
            string commandText = @"SELECT count(*) as [Count] FROM [dbo].[CustomerServiceChuli] " + where;

            using (SqlHelper helper = new SqlHelper())
            {
                var obj = helper.ExecuteScalar(commandText, CommandType.Text, parameters);
                if (obj != null && obj != DBNull.Value)
                {
                    return Convert.ToInt64(obj);
                }
            }
            return 0;
        }
		#endregion
		
		#region Subclasses
		public static partial class CustomerServiceChuli_Properties
		{
			public const string ID = "ID";
			public const string ServiceID = "ServiceID";
			public const string ChuliDate = "ChuliDate";
			public const string ChuliNote = "ChuliNote";
			public const string AddTime = "AddTime";
			public const string HandelFee = "HandelFee";
			public const string OtherFee = "OtherFee";
            
            public static Dictionary<string,string> AllPropertiesDescription=new Dictionary<string,string>(){
    			 {"ID" , "int:"},
    			 {"ServiceID" , "int:"},
    			 {"ChuliDate" , "DateTime:"},
    			 {"ChuliNote" , "string:"},
    			 {"AddTime" , "DateTime:"},
    			 {"HandelFee" , "decimal:"},
    			 {"OtherFee" , "decimal:"},
            };
		}
		#endregion
	}
}
