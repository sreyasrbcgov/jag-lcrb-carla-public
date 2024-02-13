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
    /// Microsoft.Dynamics.CRM.msdyn_federatedarticle
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynFederatedarticle
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynFederatedarticle class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynFederatedarticle()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynFederatedarticle class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynFederatedarticle(string msdynTitle = default(string), string _owningteamValue = default(string), int? statecode = default(int?), int? statuscode = default(int?), string _createdonbehalfbyValue = default(string), string _msdynSearchprovideridValue = default(string), string msdynSearchproviderarticleid = default(string), string _owneridValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string versionnumber = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), string msdynFederatedarticleid = default(string), string _owningbusinessunitValue = default(string), int? importsequencenumber = default(int?), string msdynUrl = default(string), string _owninguserValue = default(string), string _createdbyValue = default(string), string _modifiedonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> msdynFederatedarticleSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynFederatedarticleDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynFederatedarticleDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> msdynFederatedarticleAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynFederatedarticleMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynFederatedarticleProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynFederatedarticleBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynFederatedarticlePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMmsdynKmfederatedsearchconfig msdynSearchproviderid = default(MicrosoftDynamicsCRMmsdynKmfederatedsearchconfig), IList<MicrosoftDynamicsCRMmsdynFederatedarticleincident> msdynFederatedarticleMsdynFederatedarticleincidentFederatedarticleId = default(IList<MicrosoftDynamicsCRMmsdynFederatedarticleincident>))
        {
            MsdynTitle = msdynTitle;
            this._owningteamValue = _owningteamValue;
            Statecode = statecode;
            Statuscode = statuscode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._msdynSearchprovideridValue = _msdynSearchprovideridValue;
            MsdynSearchproviderarticleid = msdynSearchproviderarticleid;
            this._owneridValue = _owneridValue;
            Createdon = createdon;
            Versionnumber = versionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            Overriddencreatedon = overriddencreatedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            MsdynFederatedarticleid = msdynFederatedarticleid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Importsequencenumber = importsequencenumber;
            MsdynUrl = msdynUrl;
            this._owninguserValue = _owninguserValue;
            this._createdbyValue = _createdbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            MsdynFederatedarticleSyncErrors = msdynFederatedarticleSyncErrors;
            MsdynFederatedarticleDuplicateMatchingRecord = msdynFederatedarticleDuplicateMatchingRecord;
            MsdynFederatedarticleDuplicateBaseRecord = msdynFederatedarticleDuplicateBaseRecord;
            MsdynFederatedarticleAsyncOperations = msdynFederatedarticleAsyncOperations;
            MsdynFederatedarticleMailboxTrackingFolders = msdynFederatedarticleMailboxTrackingFolders;
            MsdynFederatedarticleProcessSession = msdynFederatedarticleProcessSession;
            MsdynFederatedarticleBulkDeleteFailures = msdynFederatedarticleBulkDeleteFailures;
            MsdynFederatedarticlePrincipalObjectAttributeAccesses = msdynFederatedarticlePrincipalObjectAttributeAccesses;
            MsdynSearchproviderid = msdynSearchproviderid;
            MsdynFederatedarticleMsdynFederatedarticleincidentFederatedarticleId = msdynFederatedarticleMsdynFederatedarticleincidentFederatedarticleId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_title")]
        public string MsdynTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_searchproviderid_value")]
        public string _msdynSearchprovideridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_searchproviderarticleid")]
        public string MsdynSearchproviderarticleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticleid")]
        public string MsdynFederatedarticleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_url")]
        public string MsdynUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_federatedarticle_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynFederatedarticleSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticle_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynFederatedarticleDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticle_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynFederatedarticleDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticle_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynFederatedarticleAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticle_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynFederatedarticleMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticle_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynFederatedarticleProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticle_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynFederatedarticleBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticle_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynFederatedarticlePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_searchproviderid")]
        public MicrosoftDynamicsCRMmsdynKmfederatedsearchconfig MsdynSearchproviderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId")]
        public IList<MicrosoftDynamicsCRMmsdynFederatedarticleincident> MsdynFederatedarticleMsdynFederatedarticleincidentFederatedarticleId { get; set; }

    }
}
