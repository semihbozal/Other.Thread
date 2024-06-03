namespace Other.Thread.Permissions;

public static class OtherThreadPermissions
{
    public const string GroupName = "OtherThread";
    public const string Accounting = "Accounting";

    public static class Accounts
    {
        public const string HeaderPermission = GroupName + ".Accounting";
        public const string Default = HeaderPermission + ".Accounts";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }

    public static class Safes
    {
        public const string HeaderPermission = GroupName + ".Accounting.Definitions";
        public const string Default = HeaderPermission + ".Safes";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }

    public static class RevenueGroups
    {
        public const string HeaderPermission = GroupName + ".Accounting.RevenueGroups";
        public const string Default = HeaderPermission + ".RevenueGroups";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
