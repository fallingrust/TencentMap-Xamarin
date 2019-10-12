using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Map.Geolocation {

	[Register ("com/tencent/map/geolocation/TencentLocationListener", DoNotGenerateAcw=true)]
	public abstract class TencentLocationListener : Java.Lang.Object {

		internal TencentLocationListener ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocationListener']/field[@name='CELL']"
		[Register ("CELL")]
		public const string Cell = (string) "cell";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocationListener']/field[@name='GPS']"
		[Register ("GPS")]
		public const string Gps = (string) "gps";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocationListener']/field[@name='RADIO']"
		[Register ("RADIO")]
		[Obsolete ("deprecated")]
		public const string Radio = (string) "radio";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocationListener']/field[@name='STATUS_DENIED']"
		[Register ("STATUS_DENIED")]
		public const int StatusDenied = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocationListener']/field[@name='STATUS_DISABLED']"
		[Register ("STATUS_DISABLED")]
		public const int StatusDisabled = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocationListener']/field[@name='STATUS_ENABLED']"
		[Register ("STATUS_ENABLED")]
		public const int StatusEnabled = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocationListener']/field[@name='STATUS_GPS_AVAILABLE']"
		[Register ("STATUS_GPS_AVAILABLE")]
		public const int StatusGpsAvailable = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocationListener']/field[@name='STATUS_GPS_UNAVAILABLE']"
		[Register ("STATUS_GPS_UNAVAILABLE")]
		public const int StatusGpsUnavailable = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocationListener']/field[@name='STATUS_LOCATION_SWITCH_OFF']"
		[Register ("STATUS_LOCATION_SWITCH_OFF")]
		public const int StatusLocationSwitchOff = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocationListener']/field[@name='STATUS_UNKNOWN']"
		[Register ("STATUS_UNKNOWN")]
		public const int StatusUnknown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocationListener']/field[@name='WIFI']"
		[Register ("WIFI")]
		public const string Wifi = (string) "wifi";
	}

	[Register ("com/tencent/map/geolocation/TencentLocationListener", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'TencentLocationListener' type. This type will be removed in a future release.")]
	public abstract class TencentLocationListenerConsts : TencentLocationListener {

		private TencentLocationListenerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocationListener']"
	[Register ("com/tencent/map/geolocation/TencentLocationListener", "", "Com.Tencent.Map.Geolocation.ITencentLocationListenerInvoker")]
	public partial interface ITencentLocationListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocationListener']/method[@name='onLocationChanged' and count(parameter)=3 and parameter[1][@type='com.tencent.map.geolocation.TencentLocation'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onLocationChanged", "(Lcom/tencent/map/geolocation/TencentLocation;ILjava/lang/String;)V", "GetOnLocationChanged_Lcom_tencent_map_geolocation_TencentLocation_ILjava_lang_String_Handler:Com.Tencent.Map.Geolocation.ITencentLocationListenerInvoker, TencentMapBind")]
		void OnLocationChanged (global::Com.Tencent.Map.Geolocation.ITencentLocation p0, int p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocationListener']/method[@name='onStatusUpdate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onStatusUpdate", "(Ljava/lang/String;ILjava/lang/String;)V", "GetOnStatusUpdate_Ljava_lang_String_ILjava_lang_String_Handler:Com.Tencent.Map.Geolocation.ITencentLocationListenerInvoker, TencentMapBind")]
		void OnStatusUpdate (string p0, int p1, string p2);

	}

	[global::Android.Runtime.Register ("com/tencent/map/geolocation/TencentLocationListener", DoNotGenerateAcw=true)]
	internal class ITencentLocationListenerInvoker : global::Java.Lang.Object, ITencentLocationListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/tencent/map/geolocation/TencentLocationListener", typeof (ITencentLocationListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ITencentLocationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITencentLocationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.map.geolocation.TencentLocationListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITencentLocationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLocationChanged_Lcom_tencent_map_geolocation_TencentLocation_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Lcom_tencent_map_geolocation_TencentLocation_ILjava_lang_String_Handler ()
		{
			if (cb_onLocationChanged_Lcom_tencent_map_geolocation_TencentLocation_ILjava_lang_String_ == null)
				cb_onLocationChanged_Lcom_tencent_map_geolocation_TencentLocation_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnLocationChanged_Lcom_tencent_map_geolocation_TencentLocation_ILjava_lang_String_);
			return cb_onLocationChanged_Lcom_tencent_map_geolocation_TencentLocation_ILjava_lang_String_;
		}

		static void n_OnLocationChanged_Lcom_tencent_map_geolocation_TencentLocation_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocationListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Map.Geolocation.ITencentLocation p0 = (global::Com.Tencent.Map.Geolocation.ITencentLocation)global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onLocationChanged_Lcom_tencent_map_geolocation_TencentLocation_ILjava_lang_String_;
		public unsafe void OnLocationChanged (global::Com.Tencent.Map.Geolocation.ITencentLocation p0, int p1, string p2)
		{
			if (id_onLocationChanged_Lcom_tencent_map_geolocation_TencentLocation_ILjava_lang_String_ == IntPtr.Zero)
				id_onLocationChanged_Lcom_tencent_map_geolocation_TencentLocation_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Lcom/tencent/map/geolocation/TencentLocation;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocationChanged_Lcom_tencent_map_geolocation_TencentLocation_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onStatusUpdate_Ljava_lang_String_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnStatusUpdate_Ljava_lang_String_ILjava_lang_String_Handler ()
		{
			if (cb_onStatusUpdate_Ljava_lang_String_ILjava_lang_String_ == null)
				cb_onStatusUpdate_Ljava_lang_String_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnStatusUpdate_Ljava_lang_String_ILjava_lang_String_);
			return cb_onStatusUpdate_Ljava_lang_String_ILjava_lang_String_;
		}

		static void n_OnStatusUpdate_Ljava_lang_String_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocationListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnStatusUpdate (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onStatusUpdate_Ljava_lang_String_ILjava_lang_String_;
		public unsafe void OnStatusUpdate (string p0, int p1, string p2)
		{
			if (id_onStatusUpdate_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
				id_onStatusUpdate_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onStatusUpdate", "(Ljava/lang/String;ILjava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStatusUpdate_Ljava_lang_String_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	// event args for com.tencent.map.geolocation.TencentLocationListener.onLocationChanged
	public partial class LocationChangedEventArgs : global::System.EventArgs {

		public LocationChangedEventArgs (global::Com.Tencent.Map.Geolocation.ITencentLocation p0, int p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Tencent.Map.Geolocation.ITencentLocation p0;
		public global::Com.Tencent.Map.Geolocation.ITencentLocation P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}
	}

	// event args for com.tencent.map.geolocation.TencentLocationListener.onStatusUpdate
	public partial class StatusUpdateEventArgs : global::System.EventArgs {

		public StatusUpdateEventArgs (string p0, int p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/tencent/map/geolocation/TencentLocationListenerImplementor")]
	internal sealed partial class ITencentLocationListenerImplementor : global::Java.Lang.Object, ITencentLocationListener {

		object sender;

		public ITencentLocationListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/map/geolocation/TencentLocationListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<LocationChangedEventArgs> OnLocationChangedHandler;
#pragma warning restore 0649

		public void OnLocationChanged (global::Com.Tencent.Map.Geolocation.ITencentLocation p0, int p1, string p2)
		{
			var __h = OnLocationChangedHandler;
			if (__h != null)
				__h (sender, new LocationChangedEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<StatusUpdateEventArgs> OnStatusUpdateHandler;
#pragma warning restore 0649

		public void OnStatusUpdate (string p0, int p1, string p2)
		{
			var __h = OnStatusUpdateHandler;
			if (__h != null)
				__h (sender, new StatusUpdateEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (ITencentLocationListenerImplementor value)
		{
			return value.OnLocationChangedHandler == null && value.OnStatusUpdateHandler == null;
		}
	}

}
