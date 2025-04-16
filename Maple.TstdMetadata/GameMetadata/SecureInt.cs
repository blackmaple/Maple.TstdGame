
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.TstdMetadata
{
    
    
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."SecureInt"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000022U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [83, 101, 99, 117, 114, 101, 73, 110, 116])]
    
                
    // struct 0x10 System.Int32 encryptedValue
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"encryptedValue", "ENCRYPTED_VALUE")]
            
    // struct 0x14 System.Boolean max
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"max", "MAX")]
            
    // struct 0x18 System.UInt32 signature
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"signature", "SIGNATURE")]
    public partial class SecureInt
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "SecureInt";
        //public static byte[] Static_ClassName { get; } = [83, 101, 99, 117, 114, 101, 73, 110, 116];

        //public const uint Const_TypeToken = 0x02000022U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_SecureInt(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_SecureInt(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_SecureInt obj) => obj._ptr;
            public static implicit operator bool(Ptr_SecureInt obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll".""."SecureInt"]
        /// </summary>
        public partial class SecureInt
        { 

            
            
            /// <summary>
            ///   System.Void .ctor(System.Int32 value, System.Boolean max)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <param name="max">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR (System.Int32 value, System.Boolean max);

            
            /// <summary>
            /// static  System.UInt32 CRC32Custom(System.String input)
            /// </summary>
            /// <param name="input">class System.String</param>
            /// <returns>struct System.UInt32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CRC32Custom")]
            /// static extern System.UInt32 CRC32_CUSTOM (nint input);

            
            /// <summary>
            /// static  System.Int32 Decrypt(System.Int32 value, System.Int32 key)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <param name="key">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt")]
             static extern System.Int32 DECRYPT (System.Int32 value, System.Int32 key);

            
            /// <summary>
            /// static  System.Int32 Encrypt(System.Int32 value, System.Int32 key)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <param name="key">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt")]
             static extern System.Int32 ENCRYPT (System.Int32 value, System.Int32 key);

            
            /// <summary>
            ///   System.Int32 GetKey()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetKey")]
            ///  extern System.Int32 GET_KEY ();

            
            /// <summary>
            ///   System.Void Init(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init")]
            ///  extern void INIT (System.Int32 value);

            
            /// <summary>
            /// static  System.Int32 op_Implicit(SecureInt secureInt)
            /// </summary>
            /// <param name="secureInt">class SecureInt</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit")]
            /// static extern System.Int32 OP_IMPLICIT (nint secureInt);

            
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
            ///  extern nint TO_STRING ();

            
            /// <summary>
            ///   System.Boolean ValidateSignature()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ValidateSignature")]
            ///  extern System.Boolean VALIDATE_SIGNATURE ();
            
            

            
            /// public static partial class Search_SecureInt
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}