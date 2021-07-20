﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.3705.0
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace Client {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class dsMemb : DataSet {
        
        private memberDataTable tablemember;
        
        public dsMemb() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected dsMemb(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["member"] != null)) {
                    this.Tables.Add(new memberDataTable(ds.Tables["member"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public memberDataTable member {
            get {
                return this.tablemember;
            }
        }
        
        public override DataSet Clone() {
            dsMemb cln = ((dsMemb)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["member"] != null)) {
                this.Tables.Add(new memberDataTable(ds.Tables["member"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tablemember = ((memberDataTable)(this.Tables["member"]));
            if ((this.tablemember != null)) {
                this.tablemember.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "dsMemb";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/dsMemb.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablemember = new memberDataTable();
            this.Tables.Add(this.tablemember);
        }
        
        private bool ShouldSerializemember() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void memberRowChangeEventHandler(object sender, memberRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class memberDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnAddress;
            
            private DataColumn columnAmount;
            
            private DataColumn columnBalanced_Time;
            
            private DataColumn columnDate;
            
            private DataColumn column_E_Mail_ID;
            
            private DataColumn columnFavourite_Sites;
            
            private DataColumn columnID;
            
            private DataColumn columnName;
            
            private DataColumn columnParentage;
            
            private DataColumn columnPassCode;
            
            private DataColumn columnTotal_Time_Alloted;
            
            private DataColumn columnUser_ID;
            
            internal memberDataTable() : 
                    base("member") {
                this.InitClass();
            }
            
            internal memberDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn AddressColumn {
                get {
                    return this.columnAddress;
                }
            }
            
            internal DataColumn AmountColumn {
                get {
                    return this.columnAmount;
                }
            }
            
            internal DataColumn Balanced_TimeColumn {
                get {
                    return this.columnBalanced_Time;
                }
            }
            
            internal DataColumn DateColumn {
                get {
                    return this.columnDate;
                }
            }
            
            internal DataColumn _E_Mail_IDColumn {
                get {
                    return this.column_E_Mail_ID;
                }
            }
            
            internal DataColumn Favourite_SitesColumn {
                get {
                    return this.columnFavourite_Sites;
                }
            }
            
            internal DataColumn IDColumn {
                get {
                    return this.columnID;
                }
            }
            
            internal DataColumn NameColumn {
                get {
                    return this.columnName;
                }
            }
            
            internal DataColumn ParentageColumn {
                get {
                    return this.columnParentage;
                }
            }
            
            internal DataColumn PassCodeColumn {
                get {
                    return this.columnPassCode;
                }
            }
            
            internal DataColumn Total_Time_AllotedColumn {
                get {
                    return this.columnTotal_Time_Alloted;
                }
            }
            
            internal DataColumn User_IDColumn {
                get {
                    return this.columnUser_ID;
                }
            }
            
            public memberRow this[int index] {
                get {
                    return ((memberRow)(this.Rows[index]));
                }
            }
            
            public event memberRowChangeEventHandler memberRowChanged;
            
            public event memberRowChangeEventHandler memberRowChanging;
            
            public event memberRowChangeEventHandler memberRowDeleted;
            
            public event memberRowChangeEventHandler memberRowDeleting;
            
            public void AddmemberRow(memberRow row) {
                this.Rows.Add(row);
            }
            
            public memberRow AddmemberRow(string Address, System.Decimal Amount, System.Double Balanced_Time, System.DateTime Date, string _E_Mail_ID, string Favourite_Sites, string ID, string Name, string Parentage, string PassCode, System.Double Total_Time_Alloted, string User_ID) {
                memberRow rowmemberRow = ((memberRow)(this.NewRow()));
                rowmemberRow.ItemArray = new object[] {
                        Address,
                        Amount,
                        Balanced_Time,
                        Date,
                        _E_Mail_ID,
                        Favourite_Sites,
                        ID,
                        Name,
                        Parentage,
                        PassCode,
                        Total_Time_Alloted,
                        User_ID};
                this.Rows.Add(rowmemberRow);
                return rowmemberRow;
            }
            
            public memberRow FindByID(string ID) {
                return ((memberRow)(this.Rows.Find(new object[] {
                            ID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                memberDataTable cln = ((memberDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new memberDataTable();
            }
            
            internal void InitVars() {
                this.columnAddress = this.Columns["Address"];
                this.columnAmount = this.Columns["Amount"];
                this.columnBalanced_Time = this.Columns["Balanced Time"];
                this.columnDate = this.Columns["Date"];
                this.column_E_Mail_ID = this.Columns["E-Mail ID"];
                this.columnFavourite_Sites = this.Columns["Favourite Sites"];
                this.columnID = this.Columns["ID"];
                this.columnName = this.Columns["Name"];
                this.columnParentage = this.Columns["Parentage"];
                this.columnPassCode = this.Columns["PassCode"];
                this.columnTotal_Time_Alloted = this.Columns["Total Time Alloted"];
                this.columnUser_ID = this.Columns["User ID"];
            }
            
            private void InitClass() {
                this.columnAddress = new DataColumn("Address", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress);
                this.columnAmount = new DataColumn("Amount", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAmount);
                this.columnBalanced_Time = new DataColumn("Balanced Time", typeof(System.Double), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnBalanced_Time);
                this.columnDate = new DataColumn("Date", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDate);
                this.column_E_Mail_ID = new DataColumn("E-Mail ID", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.column_E_Mail_ID);
                this.columnFavourite_Sites = new DataColumn("Favourite Sites", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFavourite_Sites);
                this.columnID = new DataColumn("ID", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnID);
                this.columnName = new DataColumn("Name", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnName);
                this.columnParentage = new DataColumn("Parentage", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnParentage);
                this.columnPassCode = new DataColumn("PassCode", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPassCode);
                this.columnTotal_Time_Alloted = new DataColumn("Total Time Alloted", typeof(System.Double), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTotal_Time_Alloted);
                this.columnUser_ID = new DataColumn("User ID", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUser_ID);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnID}, true));
                this.columnID.AllowDBNull = false;
                this.columnID.Unique = true;
            }
            
            public memberRow NewmemberRow() {
                return ((memberRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new memberRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(memberRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.memberRowChanged != null)) {
                    this.memberRowChanged(this, new memberRowChangeEvent(((memberRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.memberRowChanging != null)) {
                    this.memberRowChanging(this, new memberRowChangeEvent(((memberRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.memberRowDeleted != null)) {
                    this.memberRowDeleted(this, new memberRowChangeEvent(((memberRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.memberRowDeleting != null)) {
                    this.memberRowDeleting(this, new memberRowChangeEvent(((memberRow)(e.Row)), e.Action));
                }
            }
            
            public void RemovememberRow(memberRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class memberRow : DataRow {
            
            private memberDataTable tablemember;
            
            internal memberRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablemember = ((memberDataTable)(this.Table));
            }
            
            public string Address {
                get {
                    try {
                        return ((string)(this[this.tablemember.AddressColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablemember.AddressColumn] = value;
                }
            }
            
            public System.Decimal Amount {
                get {
                    try {
                        return ((System.Decimal)(this[this.tablemember.AmountColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablemember.AmountColumn] = value;
                }
            }
            
            public System.Double Balanced_Time {
                get {
                    try {
                        return ((System.Double)(this[this.tablemember.Balanced_TimeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablemember.Balanced_TimeColumn] = value;
                }
            }
            
            public System.DateTime Date {
                get {
                    try {
                        return ((System.DateTime)(this[this.tablemember.DateColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablemember.DateColumn] = value;
                }
            }
            
            public string _E_Mail_ID {
                get {
                    try {
                        return ((string)(this[this.tablemember._E_Mail_IDColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablemember._E_Mail_IDColumn] = value;
                }
            }
            
            public string Favourite_Sites {
                get {
                    try {
                        return ((string)(this[this.tablemember.Favourite_SitesColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablemember.Favourite_SitesColumn] = value;
                }
            }
            
            public string ID {
                get {
                    return ((string)(this[this.tablemember.IDColumn]));
                }
                set {
                    this[this.tablemember.IDColumn] = value;
                }
            }
            
            public string Name {
                get {
                    try {
                        return ((string)(this[this.tablemember.NameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablemember.NameColumn] = value;
                }
            }
            
            public string Parentage {
                get {
                    try {
                        return ((string)(this[this.tablemember.ParentageColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablemember.ParentageColumn] = value;
                }
            }
            
            public string PassCode {
                get {
                    try {
                        return ((string)(this[this.tablemember.PassCodeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablemember.PassCodeColumn] = value;
                }
            }
            
            public System.Double Total_Time_Alloted {
                get {
                    try {
                        return ((System.Double)(this[this.tablemember.Total_Time_AllotedColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablemember.Total_Time_AllotedColumn] = value;
                }
            }
            
            public string User_ID {
                get {
                    try {
                        return ((string)(this[this.tablemember.User_IDColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tablemember.User_IDColumn] = value;
                }
            }
            
            public bool IsAddressNull() {
                return this.IsNull(this.tablemember.AddressColumn);
            }
            
            public void SetAddressNull() {
                this[this.tablemember.AddressColumn] = System.Convert.DBNull;
            }
            
            public bool IsAmountNull() {
                return this.IsNull(this.tablemember.AmountColumn);
            }
            
            public void SetAmountNull() {
                this[this.tablemember.AmountColumn] = System.Convert.DBNull;
            }
            
            public bool IsBalanced_TimeNull() {
                return this.IsNull(this.tablemember.Balanced_TimeColumn);
            }
            
            public void SetBalanced_TimeNull() {
                this[this.tablemember.Balanced_TimeColumn] = System.Convert.DBNull;
            }
            
            public bool IsDateNull() {
                return this.IsNull(this.tablemember.DateColumn);
            }
            
            public void SetDateNull() {
                this[this.tablemember.DateColumn] = System.Convert.DBNull;
            }
            
            public bool Is_E_Mail_IDNull() {
                return this.IsNull(this.tablemember._E_Mail_IDColumn);
            }
            
            public void Set_E_Mail_IDNull() {
                this[this.tablemember._E_Mail_IDColumn] = System.Convert.DBNull;
            }
            
            public bool IsFavourite_SitesNull() {
                return this.IsNull(this.tablemember.Favourite_SitesColumn);
            }
            
            public void SetFavourite_SitesNull() {
                this[this.tablemember.Favourite_SitesColumn] = System.Convert.DBNull;
            }
            
            public bool IsNameNull() {
                return this.IsNull(this.tablemember.NameColumn);
            }
            
            public void SetNameNull() {
                this[this.tablemember.NameColumn] = System.Convert.DBNull;
            }
            
            public bool IsParentageNull() {
                return this.IsNull(this.tablemember.ParentageColumn);
            }
            
            public void SetParentageNull() {
                this[this.tablemember.ParentageColumn] = System.Convert.DBNull;
            }
            
            public bool IsPassCodeNull() {
                return this.IsNull(this.tablemember.PassCodeColumn);
            }
            
            public void SetPassCodeNull() {
                this[this.tablemember.PassCodeColumn] = System.Convert.DBNull;
            }
            
            public bool IsTotal_Time_AllotedNull() {
                return this.IsNull(this.tablemember.Total_Time_AllotedColumn);
            }
            
            public void SetTotal_Time_AllotedNull() {
                this[this.tablemember.Total_Time_AllotedColumn] = System.Convert.DBNull;
            }
            
            public bool IsUser_IDNull() {
                return this.IsNull(this.tablemember.User_IDColumn);
            }
            
            public void SetUser_IDNull() {
                this[this.tablemember.User_IDColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class memberRowChangeEvent : EventArgs {
            
            private memberRow eventRow;
            
            private DataRowAction eventAction;
            
            public memberRowChangeEvent(memberRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public memberRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
