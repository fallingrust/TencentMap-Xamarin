using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Map.Geolocation.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']"
	[global::Android.Runtime.Register ("com/tencent/map/geolocation/internal/TencentExtraKeys", DoNotGenerateAcw=true)]
	public partial class TencentExtraKeys : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='ALLOW_NLP_LOCATION']"
		[Register ("ALLOW_NLP_LOCATION")]
		public const bool AllowNlpLocation = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='LOCATION_KEY_ADMIN_LEVEL1']"
		[Register ("LOCATION_KEY_ADMIN_LEVEL1")]
		public const string LocationKeyAdminLevel1 = (string) "admin_level_1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='LOCATION_KEY_ADMIN_LEVEL2']"
		[Register ("LOCATION_KEY_ADMIN_LEVEL2")]
		public const string LocationKeyAdminLevel2 = (string) "admin_level_2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='LOCATION_KEY_ADMIN_LEVEL3']"
		[Register ("LOCATION_KEY_ADMIN_LEVEL3")]
		public const string LocationKeyAdminLevel3 = (string) "admin_level_3";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='LOCATION_KEY_LOCALITY']"
		[Register ("LOCATION_KEY_LOCALITY")]
		public const string LocationKeyLocality = (string) "locality";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='LOCATION_KEY_NATION']"
		[Register ("LOCATION_KEY_NATION")]
		public const string LocationKeyNation = (string) "nation";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='LOCATION_KEY_ROUTE']"
		[Register ("LOCATION_KEY_ROUTE")]
		public const string LocationKeyRoute = (string) "route";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='LOCATION_KEY_SUBLOCALITY']"
		[Register ("LOCATION_KEY_SUBLOCALITY")]
		public const string LocationKeySublocality = (string) "sublocality";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='LOCATION_SOURCE_CELL']"
		[Register ("LOCATION_SOURCE_CELL")]
		public const string LocationSourceCell = (string) "cell";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='LOCATION_SOURCE_GPS']"
		[Register ("LOCATION_SOURCE_GPS")]
		public const string LocationSourceGps = (string) "gps";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='LOCATION_SOURCE_WIFI']"
		[Register ("LOCATION_SOURCE_WIFI")]
		public const string LocationSourceWifi = (string) "wifi";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='MOCK_LOCATION_FILTER']"
		[Register ("MOCK_LOCATION_FILTER")]
		public static bool MockLocationFilter {
			get {
				const string __id = "MOCK_LOCATION_FILTER.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "MOCK_LOCATION_FILTER.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='RAW_DATA']"
		[Register ("RAW_DATA")]
		public const string RawData = (string) "raw_data";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='REQUEST_RAW_DATA']"
		[Register ("REQUEST_RAW_DATA")]
		public const string RequestRawData = (string) "request_raw_data";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='STRICT_CELL_FILTER']"
		[Register ("STRICT_CELL_FILTER")]
		public const bool StrictCellFilter = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/field[@name='TENCENT_INTERNAL']"
		[Register ("TENCENT_INTERNAL")]
		public const bool TencentInternal = (bool) true;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/map/geolocation/internal/TencentExtraKeys", typeof (TencentExtraKeys));
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

		protected TencentExtraKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/constructor[@name='TencentExtraKeys' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TencentExtraKeys ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		[Obsolete (@"deprecated")]
		public static unsafe bool IsDebugEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='isDebugEnabled' and count(parameter)=0]"
			[Register ("isDebugEnabled", "()Z", "GetIsDebugEnabledHandler")]
			get {
				const string __id = "isDebugEnabled.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsTencentExtraKeysDIDI_INTERNAL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='isTencentExtraKeysDIDI_INTERNAL' and count(parameter)=0]"
			[Register ("isTencentExtraKeysDIDI_INTERNAL", "()Z", "GetIsTencentExtraKeysDIDI_INTERNALHandler")]
			get {
				const string __id = "isTencentExtraKeysDIDI_INTERNAL.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsTencentExtraKeysTENCENT_INTERNAL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='isTencentExtraKeysTENCENT_INTERNAL' and count(parameter)=0]"
			[Register ("isTencentExtraKeysTENCENT_INTERNAL", "()Z", "GetIsTencentExtraKeysTENCENT_INTERNALHandler")]
			get {
				const string __id = "isTencentExtraKeysTENCENT_INTERNAL.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::Java.IO.File LogDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='getLogDir' and count(parameter)=0]"
			[Register ("getLogDir", "()Ljava/io/File;", "GetGetLogDirHandler")]
			get {
				const string __id = "getLogDir.()Ljava/io/File;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='setLogDir' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
			[Register ("setLogDir", "(Ljava/io/File;)V", "GetSetLogDir_Ljava_io_File_Handler")]
			set {
				const string __id = "setLogDir.(Ljava/io/File;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='enableMockLocationFilter' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableMockLocationFilter", "(Z)V", "")]
		public static unsafe void EnableMockLocationFilter (bool p0)
		{
			const string __id = "enableMockLocationFilter.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='getLocationSource' and count(parameter)=1 and parameter[1][@type='com.tencent.map.geolocation.TencentLocation']]"
		[Register ("getLocationSource", "(Lcom/tencent/map/geolocation/TencentLocation;)Ljava/lang/String;", "")]
		public static unsafe string GetLocationSource (global::Com.Tencent.Map.Geolocation.ITencentLocation p0)
		{
			const string __id = "getLocationSource.(Lcom/tencent/map/geolocation/TencentLocation;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='getRawData' and count(parameter)=1 and parameter[1][@type='com.tencent.map.geolocation.TencentLocation']]"
		[Register ("getRawData", "(Lcom/tencent/map/geolocation/TencentLocation;)[B", "")]
		public static unsafe byte[] GetRawData (global::Com.Tencent.Map.Geolocation.ITencentLocation p0)
		{
			const string __id = "getRawData.(Lcom/tencent/map/geolocation/TencentLocation;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='getRawGps' and count(parameter)=1 and parameter[1][@type='com.tencent.map.geolocation.TencentLocation']]"
		[Register ("getRawGps", "(Lcom/tencent/map/geolocation/TencentLocation;)Landroid/location/Location;", "")]
		public static unsafe global::Android.Locations.Location GetRawGps (global::Com.Tencent.Map.Geolocation.ITencentLocation p0)
		{
			const string __id = "getRawGps.(Lcom/tencent/map/geolocation/TencentLocation;)Landroid/location/Location;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='getRawQuery' and count(parameter)=1 and parameter[1][@type='com.tencent.map.geolocation.TencentLocation']]"
		[Register ("getRawQuery", "(Lcom/tencent/map/geolocation/TencentLocation;)Ljava/lang/String;", "")]
		public static unsafe string GetRawQuery (global::Com.Tencent.Map.Geolocation.ITencentLocation p0)
		{
			const string __id = "getRawQuery.(Lcom/tencent/map/geolocation/TencentLocation;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='initSdkLog' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File']]"
		[Register ("initSdkLog", "(Landroid/content/Context;Ljava/io/File;)V", "")]
		public static unsafe void InitSdkLog (global::Android.Content.Context p0, global::Java.IO.File p1)
		{
			const string __id = "initSdkLog.(Landroid/content/Context;Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='isAllowedLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isAllowedLevel", "(I)Z", "")]
		public static unsafe bool IsAllowedLevel (int p0)
		{
			const string __id = "isAllowedLevel.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='isInsIllegalApp' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isInsIllegalApp", "(Landroid/content/Context;)I", "")]
		public static unsafe int IsInsIllegalApp (global::Android.Content.Context p0)
		{
			const string __id = "isInsIllegalApp.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='isRequestRawData' and count(parameter)=1 and parameter[1][@type='com.tencent.map.geolocation.TencentLocationRequest']]"
		[Register ("isRequestRawData", "(Lcom/tencent/map/geolocation/TencentLocationRequest;)Z", "")]
		public static unsafe bool IsRequestRawData (global::Com.Tencent.Map.Geolocation.TencentLocationRequest p0)
		{
			const string __id = "isRequestRawData.(Lcom/tencent/map/geolocation/TencentLocationRequest;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='loadLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadLibrary", "(Ljava/lang/String;)V", "")]
		public static unsafe void LoadLibrary (string p0)
		{
			const string __id = "loadLibrary.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)V", "")]
		public static unsafe void SetContext (global::Android.Content.Context p0)
		{
			const string __id = "setContext.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='setRawData' and count(parameter)=2 and parameter[1][@type='com.tencent.map.geolocation.TencentLocation'] and parameter[2][@type='byte[]']]"
		[Register ("setRawData", "(Lcom/tencent/map/geolocation/TencentLocation;[B)Lcom/tencent/map/geolocation/TencentLocation;", "")]
		public static unsafe global::Com.Tencent.Map.Geolocation.ITencentLocation SetRawData (global::Com.Tencent.Map.Geolocation.ITencentLocation p0, byte[] p1)
		{
			const string __id = "setRawData.(Lcom/tencent/map/geolocation/TencentLocation;[B)Lcom/tencent/map/geolocation/TencentLocation;";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='setRawGps' and count(parameter)=2 and parameter[1][@type='com.tencent.map.geolocation.TencentLocation'] and parameter[2][@type='android.location.Location']]"
		[Register ("setRawGps", "(Lcom/tencent/map/geolocation/TencentLocation;Landroid/location/Location;)V", "")]
		public static unsafe void SetRawGps (global::Com.Tencent.Map.Geolocation.ITencentLocation p0, global::Android.Locations.Location p1)
		{
			const string __id = "setRawGps.(Lcom/tencent/map/geolocation/TencentLocation;Landroid/location/Location;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='setRawQuery' and count(parameter)=2 and parameter[1][@type='com.tencent.map.geolocation.TencentLocation'] and parameter[2][@type='java.lang.String']]"
		[Register ("setRawQuery", "(Lcom/tencent/map/geolocation/TencentLocation;Ljava/lang/String;)V", "")]
		public static unsafe void SetRawQuery (global::Com.Tencent.Map.Geolocation.ITencentLocation p0, string p1)
		{
			const string __id = "setRawQuery.(Lcom/tencent/map/geolocation/TencentLocation;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='setRequestRawData' and count(parameter)=2 and parameter[1][@type='com.tencent.map.geolocation.TencentLocationRequest'] and parameter[2][@type='boolean']]"
		[Register ("setRequestRawData", "(Lcom/tencent/map/geolocation/TencentLocationRequest;Z)Lcom/tencent/map/geolocation/TencentLocationRequest;", "")]
		public static unsafe global::Com.Tencent.Map.Geolocation.TencentLocationRequest SetRequestRawData (global::Com.Tencent.Map.Geolocation.TencentLocationRequest p0, bool p1)
		{
			const string __id = "setRequestRawData.(Lcom/tencent/map/geolocation/TencentLocationRequest;Z)Lcom/tencent/map/geolocation/TencentLocationRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentLocationRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.internal']/class[@name='TencentExtraKeys']/method[@name='wgs84ToGcj02' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("wgs84ToGcj02", "([D[D)Z", "")]
		public static unsafe bool Wgs84ToGcj02 (double[] p0, double[] p1)
		{
			const string __id = "wgs84ToGcj02.([D[D)Z";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
