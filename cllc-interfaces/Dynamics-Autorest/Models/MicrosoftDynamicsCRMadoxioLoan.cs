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
    /// Microsoft.Dynamics.CRM.adoxio_loan
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioLoan
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMadoxioLoan
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLoan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMadoxioLoan
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLoan(string _createdbyValue = default(string), string versionnumber = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string adoxioAmountorasset = default(string), string _modifiedbyValue = default(string), int? statuscode = default(int?), int? adoxioAddressstateprovince = default(int?), int? utcconversiontimezonecode = default(int?), string _owninguserValue = default(string), string adoxioAddresspostalcode = default(string), string adoxioName = default(string), string _owneridValue = default(string), string adoxioReasonforloan = default(string), int? statecode = default(int?), string adoxioAddressstreet = default(string), int? importsequencenumber = default(int?), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? adoxioDateofloan = default(System.DateTimeOffset?), string adoxioLoanid = default(string), string _owningbusinessunitValue = default(string), string _createdonbehalfbyValue = default(string), string _adoxioAccountidValue = default(string), int? adoxioLoantype = default(int?), string adoxioAddresscity = default(string), string adoxioTerms = default(string), string _owningteamValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioLoanSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLoanDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLoanDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioLoanAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioLoanMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioLoanProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioLoanBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioLoanPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMaccount adoxioAccountId = default(MicrosoftDynamicsCRMaccount))
        {
            this._createdbyValue = _createdbyValue;
            Versionnumber = versionnumber;
            Modifiedon = modifiedon;
            Createdon = createdon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioAmountorasset = adoxioAmountorasset;
            this._modifiedbyValue = _modifiedbyValue;
            Statuscode = statuscode;
            AdoxioAddressstateprovince = adoxioAddressstateprovince;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._owninguserValue = _owninguserValue;
            AdoxioAddresspostalcode = adoxioAddresspostalcode;
            AdoxioName = adoxioName;
            this._owneridValue = _owneridValue;
            AdoxioReasonforloan = adoxioReasonforloan;
            Statecode = statecode;
            AdoxioAddressstreet = adoxioAddressstreet;
            Importsequencenumber = importsequencenumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            AdoxioDateofloan = adoxioDateofloan;
            AdoxioLoanid = adoxioLoanid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._adoxioAccountidValue = _adoxioAccountidValue;
            AdoxioLoantype = adoxioLoantype;
            AdoxioAddresscity = adoxioAddresscity;
            AdoxioTerms = adoxioTerms;
            this._owningteamValue = _owningteamValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioLoanSyncErrors = adoxioLoanSyncErrors;
            AdoxioLoanDuplicateMatchingRecord = adoxioLoanDuplicateMatchingRecord;
            AdoxioLoanDuplicateBaseRecord = adoxioLoanDuplicateBaseRecord;
            AdoxioLoanAsyncOperations = adoxioLoanAsyncOperations;
            AdoxioLoanMailboxTrackingFolders = adoxioLoanMailboxTrackingFolders;
            AdoxioLoanProcessSession = adoxioLoanProcessSession;
            AdoxioLoanBulkDeleteFailures = adoxioLoanBulkDeleteFailures;
            AdoxioLoanPrincipalObjectAttributeAccesses = adoxioLoanPrincipalObjectAttributeAccesses;
            AdoxioAccountId = adoxioAccountId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_amountorasset")]
        public string AdoxioAmountorasset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addressstateprovince")]
        public int? AdoxioAddressstateprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addresspostalcode")]
        public string AdoxioAddresspostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_reasonforloan")]
        public string AdoxioReasonforloan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addressstreet")]
        public string AdoxioAddressstreet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofloan")]
        public System.DateTimeOffset? AdoxioDateofloan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_loanid")]
        public string AdoxioLoanid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_accountid_value")]
        public string _adoxioAccountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_loantype")]
        public int? AdoxioLoantype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addresscity")]
        public string AdoxioAddresscity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_terms")]
        public string AdoxioTerms { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_loan_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioLoanSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_loan_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLoanDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_loan_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLoanDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_loan_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioLoanAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_loan_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioLoanMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_loan_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioLoanProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_loan_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioLoanBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_loan_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioLoanPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_AccountId")]
        public MicrosoftDynamicsCRMaccount AdoxioAccountId { get; set; }

    }
}
