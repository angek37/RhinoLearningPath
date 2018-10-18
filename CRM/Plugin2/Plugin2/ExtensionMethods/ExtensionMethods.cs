using Microsoft.Xrm.Sdk;
using System;

namespace Plugin2.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static Guid GetGuidValue(this Entity target, string nombreCampo)
        {
            if (target.Contains(nombreCampo) && target[nombreCampo] != null)
                return target.GetAttributeValue<Guid>(nombreCampo);
            return Guid.Empty;
        }

        public static Guid GetEntityReferenceId(this Entity target, string nombreCampo)
        {
            if (target.Contains(nombreCampo) && target[nombreCampo] != null)
                return target.GetAttributeValue<EntityReference>(nombreCampo).Id;
            return Guid.Empty;
        }

        public static string GetEntityReferenceName(this Entity target, string nombreCampo)
        {
            if (target.Contains(nombreCampo) && target[nombreCampo] != null)
                return target.GetAttributeValue<EntityReference>(nombreCampo).Name;
            return string.Empty;
        }

        public static string GetStringValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                return target.GetAttributeValue<string>(nombreCampo);
            return string.Empty;
        }

        public static int GetIntValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                return target.GetAttributeValue<int>(nombreCampo);
            return default(int);
        }

        public static int GetOptionSetValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target.Attributes[nombreCampo] != null)
                return target.GetAttributeValue<OptionSetValue>(nombreCampo).Value;

            return 0;
        }

        public static decimal GetDecimalValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                return target.GetAttributeValue<decimal>(nombreCampo);
            return default(decimal);
        }

        public static double GetDoubleValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                return target.GetAttributeValue<double>(nombreCampo);
            return default(double);
        }

        public static decimal GetMoneyValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                return target.GetAttributeValue<Money>(nombreCampo).Value;
            return default(decimal);
        }

        public static DateTime GetDateTimeValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                return target.GetAttributeValue<DateTime>(nombreCampo);

            return DateTime.MinValue;
        }

        public static bool GetBoolValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                return target.GetAttributeValue<bool>(nombreCampo);
            return false;
        }

        #region Aliased Extension Methods

        public static decimal GetAliasedDecimalValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                if (target.GetAttributeValue<AliasedValue>(nombreCampo).Value != null)
                    return ((decimal)(target.GetAttributeValue<AliasedValue>(nombreCampo).Value));
            return default(decimal);
        }

        public static double GetAliasedDoubleValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                if (target.GetAttributeValue<AliasedValue>(nombreCampo).Value != null)
                    return ((double)(target.GetAttributeValue<AliasedValue>(nombreCampo).Value));
            return default(double);
        }

        public static int GetAliasedIntValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                if (target.GetAttributeValue<AliasedValue>(nombreCampo).Value != null)
                    return ((int)(target.GetAttributeValue<AliasedValue>(nombreCampo).Value));
            return default(int);
        }

        public static string GetAliasedStringValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                if (target.GetAttributeValue<AliasedValue>(nombreCampo).Value != null)
                    return ((string)(target.GetAttributeValue<AliasedValue>(nombreCampo).Value));
            return default(string);
        }

        public static Guid GetAliasedEntitiyReferenceId(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                if (target.GetAttributeValue<AliasedValue>(nombreCampo).Value != null)
                    return ((EntityReference)(target.GetAttributeValue<AliasedValue>(nombreCampo).Value)).Id;
            return Guid.Empty;
        }

        public static string GetAliasedEntitiyReferenceName(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                if (target.GetAttributeValue<AliasedValue>(nombreCampo).Value != null)
                    return ((EntityReference)(target.GetAttributeValue<AliasedValue>(nombreCampo).Value)).Name;
            return string.Empty;
        }

        public static bool GetAliasedBoolValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                if (target.GetAttributeValue<AliasedValue>(nombreCampo).Value != null)
                    return ((bool)(target.GetAttributeValue<AliasedValue>(nombreCampo).Value));
            return default(bool);
        }

        public static int GetAliasedOptionSetValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                if (target.GetAttributeValue<AliasedValue>(nombreCampo).Value != null)
                    return ((OptionSetValue)(target.GetAttributeValue<AliasedValue>(nombreCampo).Value)).Value;
            return default(int);
        }

        public static Guid GetAliasedGuidValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                if (target.GetAttributeValue<AliasedValue>(nombreCampo).Value != null)
                    return ((Guid)(target.GetAttributeValue<AliasedValue>(nombreCampo).Value));
            return default(Guid);
        }

        public static decimal GetAliasedMoneyValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                if (target.GetAttributeValue<AliasedValue>(nombreCampo).Value != null)
                    return ((Money)(target.GetAttributeValue<AliasedValue>(nombreCampo).Value)).Value;
            return default(decimal);
        }

        public static DateTime GetAliasedDateTimeValue(this Entity target, string nombreCampo)
        {
            if (target != null && target.Contains(nombreCampo) && target[nombreCampo] != null)
                if (target.GetAttributeValue<AliasedValue>(nombreCampo).Value != null)
                    return (DateTime)target.GetAttributeValue<AliasedValue>(nombreCampo).Value;

            return DateTime.MinValue;
        }
        #endregion
    }
}
