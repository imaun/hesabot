﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hesabot.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class BotString {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal BotString() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Hesabot.Resources.BotString", typeof(BotString).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 🤖⚠ لطفاً اطلاعات ورودی خود را چک کنید..
        /// </summary>
        public static string Common_Error {
            get {
                return ResourceManager.GetString("Common_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 🤖 💵 حسابات
        ///یک حساب میتونه یک حساب بانکی واقعی باشه یا حساب صندوق و دخل یا یک حساب مجازی باشه مثل کیف پول و موجودی نقد شما
        ///برای تعریف حساب ابتدا نام حساب و با یک فاصله موجودی اولیه حساب را به عدد وارد کنید. اگر موجودی حساب را وارد نکنید موجودی اولیه صفر در نظر گرفته میشه
        ///👇👇👇
        ///مثال : حساب بانک تجارت 100000.
        /// </summary>
        public static string Msg_Account_Create {
            get {
                return ResourceManager.GetString("Msg_Account_Create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 🤖 💵 حسابات
        ///سلام من یک ربات تلگرام هستم برای اینکه تو بتونی حساب و کتاب روزانه تو داشته باشی ✅
        ///
        ///کافیه مبلغ هزینه را بنویسید و یک هشتگ به عنوان نوع هزینه بزنید و بعد از اون هر توضیحی می خواهید بنویسید و برای بات بفرستی
        ///مثلاً پیام تون یه چیزی مثل پیام زیر باید باشه :
        ///👇👇👇
        ///50000 #خرید_روزانه از سوپر امیر
        ///
        ///به همین سادگی!
        ///بعد از ارسال به بات یک تراکنش هزینه به اسم خودتون ذخیره میشه که هر وقت بخواهید می تونید از این تراکنش ها گزارش بگیرید و هزینه هاتون رو مدیریت کنید..
        /// </summary>
        public static string Msg_Start {
            get {
                return ResourceManager.GetString("Msg_Start", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 🤖 💵 حسابات
        ///ثبت تراکنش در حسابات خیلی آسون انجام میشه.
        ///مبلغ تراکنش به علاوه یک هشتگ که نوع هزینه یا درآمد را مشخص میکنه به همراه یک توضیح دلخواه برای بات بفرستید. یه چیزی شبیه به خط زیر :
        ///👇👇👇
        ///10000 #تاکسی برای رفتن به مرکز شهر
        ///
        ///به همین راحتی! 💚.
        /// </summary>
        public static string Msg_Trx {
            get {
                return ResourceManager.GetString("Msg_Trx", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 🤖 💵 حسابات
        ///تراکنش را این به صورت وارد کنید : 
        ///عدد #هشتگ توضیحات.
        /// </summary>
        public static string Msg_Trx_Error {
            get {
                return ResourceManager.GetString("Msg_Trx_Error", resourceCulture);
            }
        }
    }
}
