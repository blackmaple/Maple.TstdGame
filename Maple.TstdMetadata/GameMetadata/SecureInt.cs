
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
    /// struct ["Assembly-CSharp.dll".""."SecureInt"]
    /// 
    /// </summary>
    public partial class SecureInt
    {


        /// <summary>
        /// struct System.Int32 encryptionKey "2146252416"
        /// </summary>
        /// public const System.Int32 ENCRYPTION_KEY=>"2146252416";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_SecureInt
        {



            /// const string Name_Field_encryptedValue = "encryptedValue";
            /// <summary>
            /// struct 0x10 System.Int32 encryptedValue
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x0)]
            public readonly System.Int32 encryptedValue;


            /// const string Name_Field_signature = "signature";
            /// <summary>
            /// struct 0x14 System.UInt32 signature
            /// </summary>
            [System.Runtime.InteropServices.FieldOffsetAttribute(0x4)]
            public readonly System.UInt32 signature;

        }

    }

    /// <summary>
    /// struct ["Assembly-CSharp.dll".""."SecureInt"]
    /// 
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000021U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [83, 101, 99, 117, 114, 101, 73, 110, 116])]


    // struct 0x10 System.Int32 encryptedValue
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"encryptedValue", "ENCRYPTED_VALUE")]

    // struct 0x14 System.UInt32 signature
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"signature", "SIGNATURE")]
    public partial class SecureInt
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "SecureInt";
        //public static byte[] Static_ClassName { get; } = [83, 101, 99, 117, 114, 101, 73, 110, 116];

        //public const uint Const_TypeToken = 0x02000021U;




        /// <summary>
        /// struct System.Int32 encryptionKey "2146252416"
        /// </summary>
        /// public const System.Int32 ENCRYPTION_KEY=>"2146252416";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_SecureInt(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_SecureInt(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_SecureInt obj) => obj._ptr;
            public static implicit operator bool(Ptr_SecureInt obj) => obj.Valid();

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
        ///   System.Void .ctor(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR (System.Int32 value);


        /// <summary>
        /// static  System.UInt32 CRC32Custom(System.String input)
        /// </summary>
        /// <param name="input">class System.String</param>
        /// <returns>struct System.UInt32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CRC32Custom")]
        static extern System.UInt32 CRC32_CUSTOM(nint input);


        /// <summary>
        /// static  System.Int32 Decrypt(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Decrypt")]
        static extern System.Int32 DECRYPT(System.Int32 value);


        /// <summary>
        /// static  System.Int32 Encrypt(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Encrypt")]
        static extern System.Int32 ENCRYPT(System.Int32 value);


        /// <summary>
        /// static  SecureInt Parse(System.String s)
        /// </summary>
        /// <param name="s">class System.String</param>
        /// <returns>struct SecureInt</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Parse")]
        /// static extern SecureInt PARSE (nint s);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
        ///  extern nint TO_STRING ();


        /// <summary>
        /// static  System.Boolean TryParse(System.String s, SecureInt& result)
        /// </summary>
        /// <param name="s">class System.String</param>
        /// <param name="result">struct SecureInt&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryParse")]
        /// static extern System.Boolean TRY_PARSE (nint s, SecureInt& result);


        /// <summary>
        ///   System.Boolean ValidateSignature()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ValidateSignature")]
        ///  extern System.Boolean VALIDATE_SIGNATURE ();



        /// <summary>
        /// static  SecureInt op_Implicit(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct SecureInt</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_SecureInt))]
        /// static extern SecureInt OP_IMPLICIT_00 (System.Int32 value);


        /// <summary>
        /// static  System.Int32 op_Implicit(SecureInt secureInt)
        /// </summary>
        /// <param name="secureInt">struct SecureInt</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit", Search = typeof(Search_SecureInt))]
        /// static extern System.Int32 OP_IMPLICIT_01 (SecureInt secureInt);


        /// public static partial class Search_SecureInt
        /// {
        /// 
        ///     

        /// <summary>
        /// static  SecureInt op_Implicit(System.Int32 value)
        /// </summary>
        /// public static bool OP_IMPLICIT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Int32 op_Implicit(SecureInt secureInt)
        /// </summary>
        /// public static bool OP_IMPLICIT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "op_Implicit", "SecureInt");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}