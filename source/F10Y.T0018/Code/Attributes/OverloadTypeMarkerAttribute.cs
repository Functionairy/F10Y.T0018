using System;

using F10Y.T0000;
using F10Y.T0011;


namespace F10Y.T0018
{
    /// <summary>
    /// Marker attribute indicating a struct is an overload type (a dummy struct that provides a type for use in differentiating between overloaded methods using the overload token).
    /// The marker attribute is useful for surveying structs that are overload type markers.
    /// </summary>
    /// <remarks>
    /// It's better to use a strong-type for the overloaded input value.
    /// But these overload types can be useful even in that case, where you might have function overloads of strongly-typed values.
    /// </remarks>
    [AttributeUsage(
        AttributeTargets.Struct, // Only apply to structs, since they only exist on the stack and thus do not require any memory cleanup.
        AllowMultiple = false, // A struct is either an overload type, or it is not.
        Inherited = false  // Structs cannot be inherited, but still, ensure every overload type explicitly declares itself to be an overload type.
        )]
    [MarkerAttributeMarker]
    [InstanceIdentity("9F91073D-176E-4848-B99D-711DFAC78E81")]
    public class OverloadTypeMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a struct is *not* an overload type marker.
        /// This is useful for marking structs that end up canonical overload type marker file locations, but are not overload type markers.
        /// </summary>
        public bool Is_OverloadTypeMarker { get; }


        public OverloadTypeMarkerAttribute(
            bool is_OverloadTypeMarker = true)
        {
            this.Is_OverloadTypeMarker = is_OverloadTypeMarker;
        }
    }
}
