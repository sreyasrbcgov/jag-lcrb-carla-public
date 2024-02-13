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
    /// Microsoft.Dynamics.CRM.EntityMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMEntityMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMEntityMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMEntityMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMEntityMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMEntityMetadata(int? activityTypeMask = default(int?), bool? autoRouteToOwnerQueue = default(bool?), bool? canTriggerWorkflow = default(bool?), string description = default(string), string displayCollectionName = default(string), string displayName = default(string), bool? entityHelpUrlEnabled = default(bool?), string entityHelpUrl = default(string), bool? isDocumentManagementEnabled = default(bool?), bool? isOneNoteIntegrationEnabled = default(bool?), bool? isInteractionCentricEnabled = default(bool?), bool? isKnowledgeManagementEnabled = default(bool?), bool? isSLAEnabled = default(bool?), bool? isBPFEntity = default(bool?), bool? isDocumentRecommendationsEnabled = default(bool?), bool? isMSTeamsIntegrationEnabled = default(bool?), string settingOf = default(string), string dataProviderId = default(string), string dataSourceId = default(string), bool? autoCreateAccessTeams = default(bool?), bool? isActivity = default(bool?), bool? isActivityParty = default(bool?), string isAuditEnabled = default(string), bool? isAvailableOffline = default(bool?), bool? isChildEntity = default(bool?), bool? isAIRUpdated = default(bool?), string isValidForQueue = default(string), string isConnectionsEnabled = default(string), string iconLargeName = default(string), string iconMediumName = default(string), string iconSmallName = default(string), string iconVectorName = default(string), bool? isCustomEntity = default(bool?), bool? isBusinessProcessEnabled = default(bool?), string isCustomizable = default(string), string isRenameable = default(string), string isMappable = default(string), string isDuplicateDetectionEnabled = default(string), string canCreateAttributes = default(string), string canCreateForms = default(string), string canCreateViews = default(string), string canCreateCharts = default(string), string canBeRelatedEntityInRelationship = default(string), string canBePrimaryEntityInRelationship = default(string), string canBeInManyToMany = default(string), string canBeInCustomEntityAssociation = default(string), string canEnableSyncToExternalSearchIndex = default(string), bool? syncToExternalSearchIndex = default(bool?), string canModifyAdditionalSettings = default(string), string canChangeHierarchicalRelationship = default(string), bool? isOptimisticConcurrencyEnabled = default(bool?), bool? changeTrackingEnabled = default(bool?), string canChangeTrackingBeEnabled = default(string), bool? isImportable = default(bool?), bool? isIntersect = default(bool?), string isMailMergeEnabled = default(string), bool? isManaged = default(bool?), bool? isEnabledForCharts = default(bool?), bool? isEnabledForTrace = default(bool?), bool? isValidForAdvancedFind = default(bool?), string isVisibleInMobile = default(string), string isVisibleInMobileClient = default(string), string isReadOnlyInMobileClient = default(string), string isOfflineInMobileClient = default(string), int? daysSinceRecordLastModified = default(int?), string mobileOfflineFilters = default(string), bool? isReadingPaneEnabled = default(bool?), bool? isQuickCreateEnabled = default(bool?), string logicalName = default(string), int? objectTypeCode = default(int?), string ownershipType = default(string), string primaryNameAttribute = default(string), string primaryImageAttribute = default(string), string primaryIdAttribute = default(string), IList<object> privileges = default(IList<object>), string recurrenceBaseEntityLogicalName = default(string), string reportViewName = default(string), string schemaName = default(string), string introducedVersion = default(string), bool? isStateModelAware = default(bool?), bool? enforceStateTransitions = default(bool?), string externalName = default(string), string entityColor = default(string), string logicalCollectionName = default(string), string externalCollectionName = default(string), string collectionSchemaName = default(string), string entitySetName = default(string), bool? isEnabledForExternalChannels = default(bool?), bool? isPrivate = default(bool?), bool? usesBusinessDataLabelTable = default(bool?), bool? isLogicalEntity = default(bool?), bool? hasNotes = default(bool?), bool? hasActivities = default(bool?), bool? hasFeedback = default(bool?), bool? isSolutionAware = default(bool?), IList<object> settings = default(IList<object>), System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedOn = default(System.DateTimeOffset?), bool? hasEmailAddresses = default(bool?), IList<MicrosoftDynamicsCRMAttributeMetadata> attributes = default(IList<MicrosoftDynamicsCRMAttributeMetadata>), IList<MicrosoftDynamicsCRMManyToManyRelationshipMetadata> manyToManyRelationships = default(IList<MicrosoftDynamicsCRMManyToManyRelationshipMetadata>), IList<MicrosoftDynamicsCRMOneToManyRelationshipMetadata> manyToOneRelationships = default(IList<MicrosoftDynamicsCRMOneToManyRelationshipMetadata>), IList<MicrosoftDynamicsCRMOneToManyRelationshipMetadata> oneToManyRelationships = default(IList<MicrosoftDynamicsCRMOneToManyRelationshipMetadata>), IList<MicrosoftDynamicsCRMEntityKeyMetadata> keys = default(IList<MicrosoftDynamicsCRMEntityKeyMetadata>))
        {
            ActivityTypeMask = activityTypeMask;
            AutoRouteToOwnerQueue = autoRouteToOwnerQueue;
            CanTriggerWorkflow = canTriggerWorkflow;
            Description = description;
            DisplayCollectionName = displayCollectionName;
            DisplayName = displayName;
            EntityHelpUrlEnabled = entityHelpUrlEnabled;
            EntityHelpUrl = entityHelpUrl;
            IsDocumentManagementEnabled = isDocumentManagementEnabled;
            IsOneNoteIntegrationEnabled = isOneNoteIntegrationEnabled;
            IsInteractionCentricEnabled = isInteractionCentricEnabled;
            IsKnowledgeManagementEnabled = isKnowledgeManagementEnabled;
            IsSLAEnabled = isSLAEnabled;
            IsBPFEntity = isBPFEntity;
            IsDocumentRecommendationsEnabled = isDocumentRecommendationsEnabled;
            IsMSTeamsIntegrationEnabled = isMSTeamsIntegrationEnabled;
            SettingOf = settingOf;
            DataProviderId = dataProviderId;
            DataSourceId = dataSourceId;
            AutoCreateAccessTeams = autoCreateAccessTeams;
            IsActivity = isActivity;
            IsActivityParty = isActivityParty;
            IsAuditEnabled = isAuditEnabled;
            IsAvailableOffline = isAvailableOffline;
            IsChildEntity = isChildEntity;
            IsAIRUpdated = isAIRUpdated;
            IsValidForQueue = isValidForQueue;
            IsConnectionsEnabled = isConnectionsEnabled;
            IconLargeName = iconLargeName;
            IconMediumName = iconMediumName;
            IconSmallName = iconSmallName;
            IconVectorName = iconVectorName;
            IsCustomEntity = isCustomEntity;
            IsBusinessProcessEnabled = isBusinessProcessEnabled;
            IsCustomizable = isCustomizable;
            IsRenameable = isRenameable;
            IsMappable = isMappable;
            IsDuplicateDetectionEnabled = isDuplicateDetectionEnabled;
            CanCreateAttributes = canCreateAttributes;
            CanCreateForms = canCreateForms;
            CanCreateViews = canCreateViews;
            CanCreateCharts = canCreateCharts;
            CanBeRelatedEntityInRelationship = canBeRelatedEntityInRelationship;
            CanBePrimaryEntityInRelationship = canBePrimaryEntityInRelationship;
            CanBeInManyToMany = canBeInManyToMany;
            CanBeInCustomEntityAssociation = canBeInCustomEntityAssociation;
            CanEnableSyncToExternalSearchIndex = canEnableSyncToExternalSearchIndex;
            SyncToExternalSearchIndex = syncToExternalSearchIndex;
            CanModifyAdditionalSettings = canModifyAdditionalSettings;
            CanChangeHierarchicalRelationship = canChangeHierarchicalRelationship;
            IsOptimisticConcurrencyEnabled = isOptimisticConcurrencyEnabled;
            ChangeTrackingEnabled = changeTrackingEnabled;
            CanChangeTrackingBeEnabled = canChangeTrackingBeEnabled;
            IsImportable = isImportable;
            IsIntersect = isIntersect;
            IsMailMergeEnabled = isMailMergeEnabled;
            IsManaged = isManaged;
            IsEnabledForCharts = isEnabledForCharts;
            IsEnabledForTrace = isEnabledForTrace;
            IsValidForAdvancedFind = isValidForAdvancedFind;
            IsVisibleInMobile = isVisibleInMobile;
            IsVisibleInMobileClient = isVisibleInMobileClient;
            IsReadOnlyInMobileClient = isReadOnlyInMobileClient;
            IsOfflineInMobileClient = isOfflineInMobileClient;
            DaysSinceRecordLastModified = daysSinceRecordLastModified;
            MobileOfflineFilters = mobileOfflineFilters;
            IsReadingPaneEnabled = isReadingPaneEnabled;
            IsQuickCreateEnabled = isQuickCreateEnabled;
            LogicalName = logicalName;
            ObjectTypeCode = objectTypeCode;
            OwnershipType = ownershipType;
            PrimaryNameAttribute = primaryNameAttribute;
            PrimaryImageAttribute = primaryImageAttribute;
            PrimaryIdAttribute = primaryIdAttribute;
            Privileges = privileges;
            RecurrenceBaseEntityLogicalName = recurrenceBaseEntityLogicalName;
            ReportViewName = reportViewName;
            SchemaName = schemaName;
            IntroducedVersion = introducedVersion;
            IsStateModelAware = isStateModelAware;
            EnforceStateTransitions = enforceStateTransitions;
            ExternalName = externalName;
            EntityColor = entityColor;
            LogicalCollectionName = logicalCollectionName;
            ExternalCollectionName = externalCollectionName;
            CollectionSchemaName = collectionSchemaName;
            EntitySetName = entitySetName;
            IsEnabledForExternalChannels = isEnabledForExternalChannels;
            IsPrivate = isPrivate;
            UsesBusinessDataLabelTable = usesBusinessDataLabelTable;
            IsLogicalEntity = isLogicalEntity;
            HasNotes = hasNotes;
            HasActivities = hasActivities;
            HasFeedback = hasFeedback;
            IsSolutionAware = isSolutionAware;
            Settings = settings;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            HasEmailAddresses = hasEmailAddresses;
            Attributes = attributes;
            ManyToManyRelationships = manyToManyRelationships;
            ManyToOneRelationships = manyToOneRelationships;
            OneToManyRelationships = oneToManyRelationships;
            Keys = keys;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActivityTypeMask")]
        public int? ActivityTypeMask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AutoRouteToOwnerQueue")]
        public bool? AutoRouteToOwnerQueue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanTriggerWorkflow")]
        public bool? CanTriggerWorkflow { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayCollectionName")]
        public string DisplayCollectionName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityHelpUrlEnabled")]
        public bool? EntityHelpUrlEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityHelpUrl")]
        public string EntityHelpUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDocumentManagementEnabled")]
        public bool? IsDocumentManagementEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsOneNoteIntegrationEnabled")]
        public bool? IsOneNoteIntegrationEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsInteractionCentricEnabled")]
        public bool? IsInteractionCentricEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsKnowledgeManagementEnabled")]
        public bool? IsKnowledgeManagementEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSLAEnabled")]
        public bool? IsSLAEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsBPFEntity")]
        public bool? IsBPFEntity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDocumentRecommendationsEnabled")]
        public bool? IsDocumentRecommendationsEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsMSTeamsIntegrationEnabled")]
        public bool? IsMSTeamsIntegrationEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SettingOf")]
        public string SettingOf { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DataProviderId")]
        public string DataProviderId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DataSourceId")]
        public string DataSourceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AutoCreateAccessTeams")]
        public bool? AutoCreateAccessTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsActivity")]
        public bool? IsActivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsActivityParty")]
        public bool? IsActivityParty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAuditEnabled")]
        public string IsAuditEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAvailableOffline")]
        public bool? IsAvailableOffline { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsChildEntity")]
        public bool? IsChildEntity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAIRUpdated")]
        public bool? IsAIRUpdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsValidForQueue")]
        public string IsValidForQueue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsConnectionsEnabled")]
        public string IsConnectionsEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IconLargeName")]
        public string IconLargeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IconMediumName")]
        public string IconMediumName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IconSmallName")]
        public string IconSmallName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IconVectorName")]
        public string IconVectorName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCustomEntity")]
        public bool? IsCustomEntity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsBusinessProcessEnabled")]
        public bool? IsBusinessProcessEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCustomizable")]
        public string IsCustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsRenameable")]
        public string IsRenameable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsMappable")]
        public string IsMappable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDuplicateDetectionEnabled")]
        public string IsDuplicateDetectionEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanCreateAttributes")]
        public string CanCreateAttributes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanCreateForms")]
        public string CanCreateForms { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanCreateViews")]
        public string CanCreateViews { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanCreateCharts")]
        public string CanCreateCharts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeRelatedEntityInRelationship")]
        public string CanBeRelatedEntityInRelationship { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBePrimaryEntityInRelationship")]
        public string CanBePrimaryEntityInRelationship { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeInManyToMany")]
        public string CanBeInManyToMany { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeInCustomEntityAssociation")]
        public string CanBeInCustomEntityAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanEnableSyncToExternalSearchIndex")]
        public string CanEnableSyncToExternalSearchIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SyncToExternalSearchIndex")]
        public bool? SyncToExternalSearchIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanModifyAdditionalSettings")]
        public string CanModifyAdditionalSettings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanChangeHierarchicalRelationship")]
        public string CanChangeHierarchicalRelationship { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsOptimisticConcurrencyEnabled")]
        public bool? IsOptimisticConcurrencyEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChangeTrackingEnabled")]
        public bool? ChangeTrackingEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanChangeTrackingBeEnabled")]
        public string CanChangeTrackingBeEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsImportable")]
        public bool? IsImportable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsIntersect")]
        public bool? IsIntersect { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsMailMergeEnabled")]
        public string IsMailMergeEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsManaged")]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnabledForCharts")]
        public bool? IsEnabledForCharts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnabledForTrace")]
        public bool? IsEnabledForTrace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsValidForAdvancedFind")]
        public bool? IsValidForAdvancedFind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsVisibleInMobile")]
        public string IsVisibleInMobile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsVisibleInMobileClient")]
        public string IsVisibleInMobileClient { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsReadOnlyInMobileClient")]
        public string IsReadOnlyInMobileClient { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsOfflineInMobileClient")]
        public string IsOfflineInMobileClient { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DaysSinceRecordLastModified")]
        public int? DaysSinceRecordLastModified { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MobileOfflineFilters")]
        public string MobileOfflineFilters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsReadingPaneEnabled")]
        public bool? IsReadingPaneEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsQuickCreateEnabled")]
        public bool? IsQuickCreateEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LogicalName")]
        public string LogicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ObjectTypeCode")]
        public int? ObjectTypeCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OwnershipType")]
        public string OwnershipType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrimaryNameAttribute")]
        public string PrimaryNameAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrimaryImageAttribute")]
        public string PrimaryImageAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrimaryIdAttribute")]
        public string PrimaryIdAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Privileges")]
        public IList<object> Privileges { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurrenceBaseEntityLogicalName")]
        public string RecurrenceBaseEntityLogicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReportViewName")]
        public string ReportViewName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IntroducedVersion")]
        public string IntroducedVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsStateModelAware")]
        public bool? IsStateModelAware { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EnforceStateTransitions")]
        public bool? EnforceStateTransitions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExternalName")]
        public string ExternalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityColor")]
        public string EntityColor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LogicalCollectionName")]
        public string LogicalCollectionName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExternalCollectionName")]
        public string ExternalCollectionName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CollectionSchemaName")]
        public string CollectionSchemaName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntitySetName")]
        public string EntitySetName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnabledForExternalChannels")]
        public bool? IsEnabledForExternalChannels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsPrivate")]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UsesBusinessDataLabelTable")]
        public bool? UsesBusinessDataLabelTable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsLogicalEntity")]
        public bool? IsLogicalEntity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasNotes")]
        public bool? HasNotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasActivities")]
        public bool? HasActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasFeedback")]
        public bool? HasFeedback { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSolutionAware")]
        public bool? IsSolutionAware { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Settings")]
        public IList<object> Settings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedOn")]
        public System.DateTimeOffset? CreatedOn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ModifiedOn")]
        public System.DateTimeOffset? ModifiedOn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasEmailAddresses")]
        public bool? HasEmailAddresses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Attributes")]
        public IList<MicrosoftDynamicsCRMAttributeMetadata> Attributes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ManyToManyRelationships")]
        public IList<MicrosoftDynamicsCRMManyToManyRelationshipMetadata> ManyToManyRelationships { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ManyToOneRelationships")]
        public IList<MicrosoftDynamicsCRMOneToManyRelationshipMetadata> ManyToOneRelationships { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OneToManyRelationships")]
        public IList<MicrosoftDynamicsCRMOneToManyRelationshipMetadata> OneToManyRelationships { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Keys")]
        public IList<MicrosoftDynamicsCRMEntityKeyMetadata> Keys { get; set; }

    }
}
