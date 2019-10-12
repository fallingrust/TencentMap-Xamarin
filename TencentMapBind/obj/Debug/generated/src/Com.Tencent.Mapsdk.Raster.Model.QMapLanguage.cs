using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='QMapLanguage']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/QMapLanguage", DoNotGenerateAcw=true)]
	public sealed partial class QMapLanguage : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='QMapLanguage']/field[@name='QMapLanguage_en']"
		[Register ("QMapLanguage_en")]
		public static global::Com.Tencent.Mapsdk.Raster.Model.QMapLanguage QMapLanguageEn {
			get {
				const string __id = "QMapLanguage_en.Lcom/tencent/mapsdk/raster/model/QMapLanguage;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.QMapLanguage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='QMapLanguage']/field[@name='QMapLanguage_zh']"
		[Register ("QMapLanguage_zh")]
		public static global::Com.Tencent.Mapsdk.Raster.Model.QMapLanguage QMapLanguageZh {
			get {
				const string __id = "QMapLanguage_zh.Lcom/tencent/mapsdk/raster/model/QMapLanguage;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.QMapLanguage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/mapsdk/raster/model/QMapLanguage", typeof (QMapLanguage));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal QMapLanguage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='QMapLanguage']/method[@name='getLanguageCode' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.QMapLanguage']]"
		[Register ("getLanguageCode", "(Lcom/tencent/mapsdk/raster/model/QMapLanguage;)Ljava/lang/String;", "")]
		public static unsafe string GetLanguageCode (global::Com.Tencent.Mapsdk.Raster.Model.QMapLanguage p0)
		{
			const string __id = "getLanguageCode.(Lcom/tencent/mapsdk/raster/model/QMapLanguage;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='QMapLanguage']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/QMapLanguage;", "")]
		public static unsafe global::Com.Tencent.Mapsdk.Raster.Model.QMapLanguage ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/QMapLanguage;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.QMapLanguage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='QMapLanguage']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/tencent/mapsdk/raster/model/QMapLanguage;", "")]
		public static unsafe global::Com.Tencent.Mapsdk.Raster.Model.QMapLanguage[] Values ()
		{
			const string __id = "values.()[Lcom/tencent/mapsdk/raster/model/QMapLanguage;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Tencent.Mapsdk.Raster.Model.QMapLanguage[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Tencent.Mapsdk.Raster.Model.QMapLanguage));
			} finally {
			}
		}

	}
}
