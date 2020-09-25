using SomeCompany.Erp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SomeCompany.Erp.Permissions
{
    public class ErpPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ErpPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ErpPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ErpResource>(name);
        }
    }
}
