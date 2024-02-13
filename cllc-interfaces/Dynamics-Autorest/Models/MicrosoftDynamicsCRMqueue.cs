// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.queue
    /// </summary>
    public partial class MicrosoftDynamicsCRMqueue
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMqueue class.
        /// </summary>
        public MicrosoftDynamicsCRMqueue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMqueue class.
        /// </summary>
        public MicrosoftDynamicsCRMqueue(long? entityimageTimestamp = default(long?), string versionnumber = default(string), string name = default(string), int? queueviewtype = default(int?), string entityimageUrl = default(string), int? outgoingemaildeliverymethod = default(int?), string _owningbusinessunitValue = default(string), string _modifiedbyValue = default(string), bool? ignoreunsolicitedemail = default(bool?), string emailaddress = default(string), int? incomingemaildeliverymethod = default(int?), string _owneridValue = default(string), int? importsequencenumber = default(int?), string _owninguserValue = default(string), string description = default(string), byte[] entityimage = default(byte[]), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), int? statecode = default(int?), string _organizationidValue = default(string), int? statuscode = default(int?), string _modifiedonbehalfbyValue = default(string), decimal? exchangerate = default(decimal?), string _transactioncurrencyidValue = default(string), string entityimageid = default(string), string queueid = default(string), int? emailrouteraccessapproval = default(int?), string _defaultmailboxValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), bool? isemailaddressapprovedbyo365admin = default(bool?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? numberofmembers = default(int?), string _owningteamValue = default(string), int? queuetypecode = default(int?), int? incomingemailfilteringmethod = default(int?), int? numberofitems = default(int?), MicrosoftDynamicsCRMmailbox defaultmailbox = default(MicrosoftDynamicsCRMmailbox), IList<MicrosoftDynamicsCRMprocesssession> queueProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> queueBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMbusinessunit businessunitid = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMpostfollow> queuePostFollows = default(IList<MicrosoftDynamicsCRMpostfollow>), IList<MicrosoftDynamicsCRMmailbox> mailboxRegardingQueue = default(IList<MicrosoftDynamicsCRMmailbox>), IList<MicrosoftDynamicsCRMteam> queueTeam = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMqueueitem> queueEntries = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMactivityparty> queueActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMasyncoperation> queueAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser primaryuserid = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMemail> queueEmailEmailSender = default(IList<MicrosoftDynamicsCRMemail>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsystemuser> queuemembershipAssociation = default(IList<MicrosoftDynamicsCRMsystemuser>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsyncerror> queueSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMsystemuser> queueSystemUser = default(IList<MicrosoftDynamicsCRMsystemuser>), IList<MicrosoftDynamicsCRMpostregarding> queuePostRegardings = default(IList<MicrosoftDynamicsCRMpostregarding>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> queuePrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> queueDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> queueDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>))
        {
            EntityimageTimestamp = entityimageTimestamp;
            Versionnumber = versionnumber;
            Name = name;
            Queueviewtype = queueviewtype;
            EntityimageUrl = entityimageUrl;
            Outgoingemaildeliverymethod = outgoingemaildeliverymethod;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedbyValue = _modifiedbyValue;
            Ignoreunsolicitedemail = ignoreunsolicitedemail;
            Emailaddress = emailaddress;
            Incomingemaildeliverymethod = incomingemaildeliverymethod;
            this._owneridValue = _owneridValue;
            Importsequencenumber = importsequencenumber;
            this._owninguserValue = _owninguserValue;
            Description = description;
            Entityimage = entityimage;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statecode = statecode;
            this._organizationidValue = _organizationidValue;
            Statuscode = statuscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Exchangerate = exchangerate;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Entityimageid = entityimageid;
            Queueid = queueid;
            Emailrouteraccessapproval = emailrouteraccessapproval;
            this._defaultmailboxValue = _defaultmailboxValue;
            Modifiedon = modifiedon;
            Overriddencreatedon = overriddencreatedon;
            Isemailaddressapprovedbyo365admin = isemailaddressapprovedbyo365admin;
            Createdon = createdon;
            Numberofmembers = numberofmembers;
            this._owningteamValue = _owningteamValue;
            Queuetypecode = queuetypecode;
            Incomingemailfilteringmethod = incomingemailfilteringmethod;
            Numberofitems = numberofitems;
            Defaultmailbox = defaultmailbox;
            QueueProcessSessions = queueProcessSessions;
            QueueBulkDeleteFailures = queueBulkDeleteFailures;
            Businessunitid = businessunitid;
            Organizationid = organizationid;
            QueuePostFollows = queuePostFollows;
            MailboxRegardingQueue = mailboxRegardingQueue;
            QueueTeam = queueTeam;
            QueueEntries = queueEntries;
            QueueActivityParties = queueActivityParties;
            QueueAsyncOperations = queueAsyncOperations;
            Owningbusinessunit = owningbusinessunit;
            Ownerid = ownerid;
            Primaryuserid = primaryuserid;
            QueueEmailEmailSender = queueEmailEmailSender;
            Createdby = createdby;
            Modifiedonbehalfby = modifiedonbehalfby;
            QueuemembershipAssociation = queuemembershipAssociation;
            Transactioncurrencyid = transactioncurrencyid;
            QueueSyncErrors = queueSyncErrors;
            QueueSystemUser = queueSystemUser;
            QueuePostRegardings = queuePostRegardings;
            QueuePrincipalobjectattributeaccess = queuePrincipalobjectattributeaccess;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            QueueDuplicateMatchingRecord = queueDuplicateMatchingRecord;
            QueueDuplicateBaseRecord = queueDuplicateBaseRecord;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queueviewtype")]
        public int? Queueviewtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outgoingemaildeliverymethod")]
        public int? Outgoingemaildeliverymethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ignoreunsolicitedemail")]
        public bool? Ignoreunsolicitedemail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incomingemaildeliverymethod")]
        public int? Incomingemaildeliverymethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "entityimage")]
        public byte[] Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queueid")]
        public string Queueid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailrouteraccessapproval")]
        public int? Emailrouteraccessapproval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_defaultmailbox_value")]
        public string _defaultmailboxValue { get; set; }

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
        [JsonProperty(PropertyName = "isemailaddressapprovedbyo365admin")]
        public bool? Isemailaddressapprovedbyo365admin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "numberofmembers")]
        public int? Numberofmembers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queuetypecode")]
        public int? Queuetypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incomingemailfilteringmethod")]
        public int? Incomingemailfilteringmethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "numberofitems")]
        public int? Numberofitems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultmailbox")]
        public MicrosoftDynamicsCRMmailbox Defaultmailbox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Queue_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> QueueProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Queue_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> QueueBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid")]
        public MicrosoftDynamicsCRMbusinessunit Businessunitid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queue_PostFollows")]
        public IList<MicrosoftDynamicsCRMpostfollow> QueuePostFollows { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mailbox_regarding_queue")]
        public IList<MicrosoftDynamicsCRMmailbox> MailboxRegardingQueue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queue_team")]
        public IList<MicrosoftDynamicsCRMteam> QueueTeam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queue_entries")]
        public IList<MicrosoftDynamicsCRMqueueitem> QueueEntries { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queue_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> QueueActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Queue_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> QueueAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryuserid")]
        public MicrosoftDynamicsCRMsystemuser Primaryuserid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Queue_Email_EmailSender")]
        public IList<MicrosoftDynamicsCRMemail> QueueEmailEmailSender { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queuemembership_association")]
        public IList<MicrosoftDynamicsCRMsystemuser> QueuemembershipAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Queue_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> QueueSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queue_system_user")]
        public IList<MicrosoftDynamicsCRMsystemuser> QueueSystemUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queue_PostRegardings")]
        public IList<MicrosoftDynamicsCRMpostregarding> QueuePostRegardings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queue_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> QueuePrincipalobjectattributeaccess { get; set; }

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
        [JsonProperty(PropertyName = "Queue_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> QueueDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Queue_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> QueueDuplicateBaseRecord { get; set; }

    }
}
