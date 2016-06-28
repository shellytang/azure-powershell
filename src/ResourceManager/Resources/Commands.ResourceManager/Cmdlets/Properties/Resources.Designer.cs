﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.ResourceManager.Cmdlets.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adding resource group ....
        /// </summary>
        internal static string AddingResourceGroup {
            get {
                return ResourceManager.GetString("AddingResourceGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to cancel the active deployment of resource group &apos;{0}&apos;?.
        /// </summary>
        internal static string CancelResourceGroupDeployment {
            get {
                return ResourceManager.GetString("CancelResourceGroupDeployment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancelling active resource group deployment ....
        /// </summary>
        internal static string CancelResourceGroupDeploymentMessage {
            get {
                return ResourceManager.GetString("CancelResourceGroupDeploymentMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checking deployment status in {0} seconds.
        /// </summary>
        internal static string CheckingDeploymentStatus {
            get {
                return ResourceManager.GetString("CheckingDeploymentStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to invoke the &apos;{0}&apos; action on the following resource: {1}.
        /// </summary>
        internal static string ConfirmInvokeAction {
            get {
                return ResourceManager.GetString("ConfirmInvokeAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to use the complete deployment mode? Resources in the resource group &apos;{0}&apos; which are not included in the template will be deleted..
        /// </summary>
        internal static string ConfirmOnCompleteDeploymentMode {
            get {
                return ResourceManager.GetString("ConfirmOnCompleteDeploymentMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are a guest user in the directory and are not allowed to create an application. Please contact the administrator of the directory..
        /// </summary>
        internal static string CreateApplicationNotAllowedGuestUser {
            get {
                return ResourceManager.GetString("CreateApplicationNotAllowedGuestUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create template deployment &apos;{0}&apos;.
        /// </summary>
        internal static string CreatedDeployment {
            get {
                return ResourceManager.GetString("CreatedDeployment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a deployment with Complete mode.
        /// </summary>
        internal static string CreateDeploymentCompleteMode {
            get {
                return ResourceManager.GetString("CreateDeploymentCompleteMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created resource group &apos;{0}&apos; in location &apos;{1}&apos;.
        /// </summary>
        internal static string CreatedResourceGroup {
            get {
                return ResourceManager.GetString("CreatedResourceGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are a guest user in the directory and are not allowed to create a service principal. Please contact the administrator of the directory..
        /// </summary>
        internal static string CreateServicePrincipalNotAllowedGuestUser {
            get {
                return ResourceManager.GetString("CreateServicePrincipalNotAllowedGuestUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to delete the deployment &apos;{0}&apos;?.
        /// </summary>
        internal static string DeleteResourceGroupDeployment {
            get {
                return ResourceManager.GetString("DeleteResourceGroupDeployment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting the deployment ....
        /// </summary>
        internal static string DeleteResourceGroupDeploymentMessage {
            get {
                return ResourceManager.GetString("DeleteResourceGroupDeploymentMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment &apos;{0}&apos; doesn&apos;t exist under resource group &apos;{1}&apos;.
        /// </summary>
        internal static string DeploymentDoesntExist {
            get {
                return ResourceManager.GetString("DeploymentDoesntExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find a deployment with name &apos;{0}&apos;..
        /// </summary>
        internal static string DeploymentWithNameNotFound {
            get {
                return ResourceManager.GetString("DeploymentWithNameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ExpandPrincipalGroups is only supported for a User principal.
        /// </summary>
        internal static string ExpandGroupsNotSupported {
            get {
                return ResourceManager.GetString("ExpandGroupsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The deployment validation failed.
        /// </summary>
        internal static string FailedDeploymentValidation {
            get {
                return ResourceManager.GetString("FailedDeploymentValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot parse {0} &apos;{1}&apos;.
        /// </summary>
        internal static string FailedToParseProperty {
            get {
                return ResourceManager.GetString("FailedToParseProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot set parameter &apos;{0}&apos; from TemplateParameterFile. Incompatible value &apos;{1}&apos;..
        /// </summary>
        internal static string FailureParsingTemplateParameterFile {
            get {
                return ResourceManager.GetString("FailureParsingTemplateParameterFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot set parameter &apos;{0}&apos; from TemplateParameterObject. Incompatible value &apos;{1}&apos;..
        /// </summary>
        internal static string FailureParsingTemplateParameterObject {
            get {
                return ResourceManager.GetString("FailureParsingTemplateParameterObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the feature &apos;{0}&apos; for the resource provider &apos;{1}&apos;..
        /// </summary>
        internal static string FeatureNotFound {
            get {
                return ResourceManager.GetString("FeatureNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided file path &apos;{0}&apos; already exists, do you want to override it?.
        /// </summary>
        internal static string FileAlreadyExists {
            get {
                return ResourceManager.GetString("FileAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided file path &apos;{0}&apos; already exists, do you want to override it?.
        /// </summary>
        internal static string FileAlreadyExists1 {
            get {
                return ResourceManager.GetString("FileAlreadyExists1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter type in parameters cannot be null or empty.
        /// </summary>
        internal static string GetParameterTypeError {
            get {
                return ResourceManager.GetString("GetParameterTypeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IncludeClassicAdministrators is only supported for a User principal.
        /// </summary>
        internal static string IncludeClassicAdminsNotSupported {
            get {
                return ResourceManager.GetString("IncludeClassicAdminsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid value for Actions.
        /// </summary>
        internal static string InvalidActions {
            get {
                return ResourceManager.GetString("InvalidActions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid value for AssignableScopes.
        /// </summary>
        internal static string InvalidAssignableScopes {
            get {
                return ResourceManager.GetString("InvalidAssignableScopes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid format of the resource group identifier. Expected &apos;subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}&apos;..
        /// </summary>
        internal static string InvalidFormatOfResourceGroupId {
            get {
                return ResourceManager.GetString("InvalidFormatOfResourceGroupId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid format of the resource identifier..
        /// </summary>
        internal static string InvalidFormatOfResourceId {
            get {
                return ResourceManager.GetString("InvalidFormatOfResourceId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RoleDefinition Description is invalid..
        /// </summary>
        internal static string InvalidRoleDefinitionDescription {
            get {
                return ResourceManager.GetString("InvalidRoleDefinitionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RoleDefinition Name is invalid.
        /// </summary>
        internal static string InvalidRoleDefinitionName {
            get {
                return ResourceManager.GetString("InvalidRoleDefinitionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid tag format. Expect @{Name = &quot;tagName&quot;} or @{Name = &quot;tagName&quot;; Value = &quot;tagValue&quot;}.
        /// </summary>
        internal static string InvalidTagFormat {
            get {
                return ResourceManager.GetString("InvalidTagFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid tag format. Ensure that each tag has a unique name. Example: @{Name = &quot;tagName1&quot;; Value = &quot;tagValue1&quot;}, @{Name = &quot;tagName2&quot;; Value = &quot;tagValue2&quot;}.
        /// </summary>
        internal static string InvalidTagFormatNotUniqueName {
            get {
                return ResourceManager.GetString("InvalidTagFormatNotUniqueName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find a template with identity &apos;{0}&apos;. Check the template identity and try the command again..
        /// </summary>
        internal static string InvalidTemplateIdentity {
            get {
                return ResourceManager.GetString("InvalidTemplateIdentity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invoking the &apos;{0}&apos; action on the resource..
        /// </summary>
        internal static string InvokingResourceAction {
            get {
                return ResourceManager.GetString("InvokingResourceAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Moving resource(s) ....
        /// </summary>
        internal static string MoveResourcesMessage {
            get {
                return ResourceManager.GetString("MoveResourcesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to move resource(s) into the resource group named &apos;{0}&apos; - the resource(s): &apos;{1}&apos;.
        /// </summary>
        internal static string MovingResources {
            get {
                return ResourceManager.GetString("MovingResources", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Moving resources from different source resource groups is not allowed..
        /// </summary>
        internal static string MovingResourcesFromDifferentSourceResourceGroupsNotAllowed {
            get {
                return ResourceManager.GetString("MovingResourcesFromDifferentSourceResourceGroupsNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Moving resources from different subscriptions is not currently supported..
        /// </summary>
        internal static string MovingResourcesFromDifferentSubscriptionsIsNotAllowed {
            get {
                return ResourceManager.GetString("MovingResourcesFromDifferentSubscriptionsIsNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Moving resources that are not in the default subscription is not allowed. Please select the subscription you want to move resources from and try again..
        /// </summary>
        internal static string MovingResourcesFromNonDefaultSubscriptionNotAllowed {
            get {
                return ResourceManager.GetString("MovingResourcesFromNonDefaultSubscriptionNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to move resource(s) into the resource group named &apos;{0}&apos; in the subscription named &apos;{1}&apos; and id &apos;{2}&apos; - the resource(s): &apos;{3}&apos;.
        /// </summary>
        internal static string MovingResourcesIntoNewSubscription {
            get {
                return ResourceManager.GetString("MovingResourcesIntoNewSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple role definitions found with name &apos;{0}&apos;. Specify role definition using it&apos;s Id instead..
        /// </summary>
        internal static string MultipleRoleDefinitionsFoundWithSameName {
            get {
                return ResourceManager.GetString("MultipleRoleDefinitionsFoundWithSameName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are more than one running deployment please specify one.
        /// </summary>
        internal static string MultipleRunningDeployment {
            get {
                return ResourceManager.GetString("MultipleRunningDeployment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replacing resource group ....
        /// </summary>
        internal static string NewResourceGroupMessage {
            get {
                return ResourceManager.GetString("NewResourceGroupMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replacing resource ....
        /// </summary>
        internal static string NewResourceMessage {
            get {
                return ResourceManager.GetString("NewResourceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no deployment called &apos;{0}&apos; to cancel.
        /// </summary>
        internal static string NoDeploymentToCancel {
            get {
                return ResourceManager.GetString("NoDeploymentToCancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find any deployments in resource group &apos;{0}&apos;..
        /// </summary>
        internal static string NoDeploymentWereFound {
            get {
                return ResourceManager.GetString("NoDeploymentWereFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no running deployments under resource group &apos;{0}&apos;.
        /// </summary>
        internal static string NoRunningDeployments {
            get {
                return ResourceManager.GetString("NoRunningDeployments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation failed because a request timed out..
        /// </summary>
        internal static string OperationFailedWithTimeOut {
            get {
                return ResourceManager.GetString("OperationFailedWithTimeOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To get all operations under {0}, please specify the search string as {0}/*..
        /// </summary>
        internal static string OperationSearchStringInvalidProviderName {
            get {
                return ResourceManager.GetString("OperationSearchStringInvalidProviderName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Individual parts in the search string should either equal * or not contain *..
        /// </summary>
        internal static string OperationSearchStringInvalidWildcard {
            get {
                return ResourceManager.GetString("OperationSearchStringInvalidWildcard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overriding the existing file..
        /// </summary>
        internal static string OverrdingFile {
            get {
                return ResourceManager.GetString("OverrdingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overriding the existing file..
        /// </summary>
        internal static string OverrdingFile1 {
            get {
                return ResourceManager.GetString("OverrdingFile1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find principal using the specified options.
        /// </summary>
        internal static string PrincipalNotFound {
            get {
                return ResourceManager.GetString("PrincipalNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wildcard character ? is not supported..
        /// </summary>
        internal static string ProviderOperationUnsupportedWildcard {
            get {
                return ResourceManager.GetString("ProviderOperationUnsupportedWildcard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find a registered feature named &apos;{0}&apos; for the resource provider &apos;{1}&apos;..
        /// </summary>
        internal static string RegisteredFeatureNotFound {
            get {
                return ResourceManager.GetString("RegisteredFeatureNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to register the provider &apos;{0}&apos;.
        /// </summary>
        internal static string RegisteringProvider {
            get {
                return ResourceManager.GetString("RegisteringProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to register for the feature &apos;{0}&apos; of the provider &apos;{1}&apos;.
        /// </summary>
        internal static string RegisteringProviderFeature {
            get {
                return ResourceManager.GetString("RegisteringProviderFeature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registering provider feature ....
        /// </summary>
        internal static string RegisterProviderFeatureMessage {
            get {
                return ResourceManager.GetString("RegisterProviderFeatureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registering provider ....
        /// </summary>
        internal static string RegisterProviderMessage {
            get {
                return ResourceManager.GetString("RegisterProviderMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing application ....
        /// </summary>
        internal static string RemoveApplication {
            get {
                return ResourceManager.GetString("RemoveApplication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing resource group ....
        /// </summary>
        internal static string RemoveResourceGroupMessage {
            get {
                return ResourceManager.GetString("RemoveResourceGroupMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing resource ....
        /// </summary>
        internal static string RemoveResourceMessage {
            get {
                return ResourceManager.GetString("RemoveResourceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove role definition with id &apos;{0}&apos;..
        /// </summary>
        internal static string RemoveRoleDefinition {
            get {
                return ResourceManager.GetString("RemoveRoleDefinition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove role definition with name &apos;{0}&apos;..
        /// </summary>
        internal static string RemoveRoleDefinitionWithName {
            get {
                return ResourceManager.GetString("RemoveRoleDefinitionWithName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing service principal ....
        /// </summary>
        internal static string RemoveServicePrincipal {
            get {
                return ResourceManager.GetString("RemoveServicePrincipal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove application with object id &apos;{0}&apos;..
        /// </summary>
        internal static string RemovingApplication {
            get {
                return ResourceManager.GetString("RemovingApplication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove resource &apos;{0}&apos;.
        /// </summary>
        internal static string RemovingResource {
            get {
                return ResourceManager.GetString("RemovingResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove resource group &apos;{0}&apos;.
        /// </summary>
        internal static string RemovingResourceGroup {
            get {
                return ResourceManager.GetString("RemovingResourceGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing role assignment for AD object &apos;{0}&apos; on scope &apos;{1}&apos; with role definition &apos;{2}&apos; .
        /// </summary>
        internal static string RemovingRoleAssignment {
            get {
                return ResourceManager.GetString("RemovingRoleAssignment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove service principal with object id &apos;{0}&apos;..
        /// </summary>
        internal static string RemovingServicePrincipal {
            get {
                return ResourceManager.GetString("RemovingServicePrincipal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided resource already exists. Are you sure you want to replace it?.
        /// </summary>
        internal static string ResourceAlreadyExists {
            get {
                return ResourceManager.GetString("ResourceAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided resource does not exist..
        /// </summary>
        internal static string ResourceDoesntExists {
            get {
                return ResourceManager.GetString("ResourceDoesntExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided resource group already exists. Are you sure you want to update it?.
        /// </summary>
        internal static string ResourceGroupAlreadyExists {
            get {
                return ResourceManager.GetString("ResourceGroupAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided resource group does not exist..
        /// </summary>
        internal static string ResourceGroupDoesntExists {
            get {
                return ResourceManager.GetString("ResourceGroupDoesntExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided resource group does not exist. Would you like to create it?.
        /// </summary>
        internal static string ResourceGroupDoesntExistsAdd {
            get {
                return ResourceManager.GetString("ResourceGroupDoesntExistsAdd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the resource provider &apos;{0}&apos;..
        /// </summary>
        internal static string ResourceProviderNotFound {
            get {
                return ResourceManager.GetString("ResourceProviderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not register the resource provider &apos;{0}&apos;.
        /// </summary>
        internal static string ResourceProviderRegistrationFailed {
            get {
                return ResourceManager.GetString("ResourceProviderRegistrationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not unregister the resource provider &apos;{0}&apos;.
        /// </summary>
        internal static string ResourceProviderUnregistrationFailed {
            get {
                return ResourceManager.GetString("ResourceProviderUnregistrationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource type needs to be in the ResourceProvider/type format. For example Microsoft.Web/sites..
        /// </summary>
        internal static string ResourceTypeFormat {
            get {
                return ResourceManager.GetString("ResourceTypeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Role definition id should be a valid guid..
        /// </summary>
        internal static string RoleDefinitionIdShouldBeAGuid {
            get {
                return ResourceManager.GetString("RoleDefinitionIdShouldBeAGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find role definition with name &apos;{0}&apos;..
        /// </summary>
        internal static string RoleDefinitionNotFound {
            get {
                return ResourceManager.GetString("RoleDefinitionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find role definition with id &apos;{0}&apos;..
        /// </summary>
        internal static string RoleDefinitionWithIdNotFound {
            get {
                return ResourceManager.GetString("RoleDefinitionWithIdNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service principal with object id &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string ServicePrincipalDoesntExist {
            get {
                return ResourceManager.GetString("ServicePrincipalDoesntExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Because the current subscription does not have a current storage account, you must specify the StorageAccountName parameter..
        /// </summary>
        internal static string StorageAccountNameNeedsToBeSpecified {
            get {
                return ResourceManager.GetString("StorageAccountNameNeedsToBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A subscription with the Id &apos;{0}&apos; was not found. If this is a newly created subscription you will need to re-download your subscriptions..
        /// </summary>
        internal static string SubscriptionWithTheSpecifiedIdNotFount {
            get {
                return ResourceManager.GetString("SubscriptionWithTheSpecifiedIdNotFount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A subscription with the name &apos;{0}&apos; was not found. If this is a newly created subscription you will need to re-download your subscriptions..
        /// </summary>
        internal static string SubscriptionWithTheSpecifiedNameNotFount {
            get {
                return ResourceManager.GetString("SubscriptionWithTheSpecifiedNameNotFount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template is valid..
        /// </summary>
        internal static string TemplateValid {
            get {
                return ResourceManager.GetString("TemplateValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find Gallery item &apos;{0}&apos;..
        /// </summary>
        internal static string UnableToFindGallery {
            get {
                return ResourceManager.GetString("UnableToFindGallery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to unregister the provider &apos;{0}&apos;.
        /// </summary>
        internal static string UnregisteringProvider {
            get {
                return ResourceManager.GetString("UnregisteringProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unregistering provider ....
        /// </summary>
        internal static string UnregisterProviderMessage {
            get {
                return ResourceManager.GetString("UnregisterProviderMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updated resource group &apos;{0}&apos; in location &apos;{1}&apos;.
        /// </summary>
        internal static string UpdatedResourceGroup {
            get {
                return ResourceManager.GetString("UpdatedResourceGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DeploymentDebug setting has been enabled. This can potentially log secrets like passwords used in resource property or listKeys operations when you retrieve the deployment operations through Get-AzureRmResourceGroupDeploymentOperation.
        /// </summary>
        internal static string WarnOnDeploymentDebugSetting {
            get {
                return ResourceManager.GetString("WarnOnDeploymentDebugSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The usability of Tag parameter in this cmdlet will be modified in a future release. This will impact creating, updating and appending tags for Azure resources. For more details about the change, please visit https://github.com/Azure/azure-powershell/issues/726#issuecomment-213545494.
        /// </summary>
        internal static string WarnOnTags {
            get {
                return ResourceManager.GetString("WarnOnTags", resourceCulture);
            }
        }
    }
}
