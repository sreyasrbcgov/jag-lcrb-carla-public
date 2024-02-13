// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.bookableresourcecharacteristic
    /// </summary>
    public partial class MicrosoftDynamicsCRMbookableresourcecharacteristic
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresourcecharacteristic class.
        /// </summary>
        public MicrosoftDynamicsCRMbookableresourcecharacteristic()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresourcecharacteristic class.
        /// </summary>
        public MicrosoftDynamicsCRMbookableresourcecharacteristic(System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), decimal? exchangerate = default(decimal?), int? utcconversiontimezonecode = default(int?), string _createdbyValue = default(string), int? statecode = default(int?), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), string processid = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), string _characteristicValue = default(string), string _owneridValue = default(string), string stageid = default(string), string bookableresourcecharacteristicid = default(string), string name = default(string), string _transactioncurrencyidValue = default(string), string versionnumber = default(string), int? statuscode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string _ratingvalueValue = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string traversedpath = default(string), int? importsequencenumber = default(int?), string _resourceValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourcecharacteristicDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourcecharacteristicDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMannotation> bookableresourcecharacteristicAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> bookableresourcecharacteristicAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMprocesssession> bookableresourcecharacteristicProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bookableresourcecharacteristicBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> bookableresourcecharacteristicPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMbookableresource resource = default(MicrosoftDynamicsCRMbookableresource), MicrosoftDynamicsCRMcharacteristic characteristic = default(MicrosoftDynamicsCRMcharacteristic), MicrosoftDynamicsCRMratingvalue ratingValue = default(MicrosoftDynamicsCRMratingvalue), IList<MicrosoftDynamicsCRMteam> bookableresourcecharacteristicTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> bookableresourcecharacteristicMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsyncerror> bookableResourceCharacteristicSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>))
        {
            Modifiedon = modifiedon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Exchangerate = exchangerate;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._createdbyValue = _createdbyValue;
            Statecode = statecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Processid = processid;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            this._characteristicValue = _characteristicValue;
            this._owneridValue = _owneridValue;
            Stageid = stageid;
            Bookableresourcecharacteristicid = bookableresourcecharacteristicid;
            Name = name;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Versionnumber = versionnumber;
            Statuscode = statuscode;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedbyValue = _modifiedbyValue;
            this._ratingvalueValue = _ratingvalueValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Createdon = createdon;
            Traversedpath = traversedpath;
            Importsequencenumber = importsequencenumber;
            this._resourceValue = _resourceValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BookableresourcecharacteristicDuplicateMatchingRecord = bookableresourcecharacteristicDuplicateMatchingRecord;
            BookableresourcecharacteristicDuplicateBaseRecord = bookableresourcecharacteristicDuplicateBaseRecord;
            BookableresourcecharacteristicAnnotations = bookableresourcecharacteristicAnnotations;
            BookableresourcecharacteristicAsyncOperations = bookableresourcecharacteristicAsyncOperations;
            BookableresourcecharacteristicProcessSession = bookableresourcecharacteristicProcessSession;
            BookableresourcecharacteristicBulkDeleteFailures = bookableresourcecharacteristicBulkDeleteFailures;
            BookableresourcecharacteristicPrincipalObjectAttributeAccesses = bookableresourcecharacteristicPrincipalObjectAttributeAccesses;
            Resource = resource;
            Characteristic = characteristic;
            RatingValue = ratingValue;
            BookableresourcecharacteristicTeams = bookableresourcecharacteristicTeams;
            BookableresourcecharacteristicMailboxTrackingFolders = bookableresourcecharacteristicMailboxTrackingFolders;
            Transactioncurrencyid = transactioncurrencyid;
            BookableResourceCharacteristicSyncErrors = bookableResourceCharacteristicSyncErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_characteristic_value")]
        public string _characteristicValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecharacteristicid")]
        public string Bookableresourcecharacteristicid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ratingvalue_value")]
        public string _ratingvalueValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_resource_value")]
        public string _resourceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecharacteristic_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourcecharacteristicDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecharacteristic_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourcecharacteristicDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecharacteristic_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> BookableresourcecharacteristicAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecharacteristic_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BookableresourcecharacteristicAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecharacteristic_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> BookableresourcecharacteristicProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecharacteristic_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BookableresourcecharacteristicBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecharacteristic_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> BookableresourcecharacteristicPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Resource")]
        public MicrosoftDynamicsCRMbookableresource Resource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Characteristic")]
        public MicrosoftDynamicsCRMcharacteristic Characteristic { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RatingValue")]
        public MicrosoftDynamicsCRMratingvalue RatingValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecharacteristic_Teams")]
        public IList<MicrosoftDynamicsCRMteam> BookableresourcecharacteristicTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcecharacteristic_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> BookableresourcecharacteristicMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BookableResourceCharacteristic_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BookableResourceCharacteristicSyncErrors { get; set; }

    }
}
