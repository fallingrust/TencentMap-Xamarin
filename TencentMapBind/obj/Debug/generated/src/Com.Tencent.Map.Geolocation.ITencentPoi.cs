using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Map.Geolocation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentPoi']"
	[Register ("com/tencent/map/geolocation/TencentPoi", "", "Com.Tencent.Map.Geolocation.ITencentPoiInvoker")]
	public partial interface ITencentPoi : IJavaObject {

		string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentPoi']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Ljava/lang/String;", "GetGetAddressHandler:Com.Tencent.Map.Geolocation.ITencentPoiInvoker, TencentMapBind")] get;
		}

		string Catalog {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentPoi']/method[@name='getCatalog' and count(parameter)=0]"
			[Register ("getCatalog", "()Ljava/lang/String;", "GetGetCatalogHandler:Com.Tencent.Map.Geolocation.ITencentPoiInvoker, TencentMapBind")] get;
		}

		string Direction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentPoi']/method[@name='getDirection' and count(parameter)=0]"
			[Register ("getDirection", "()Ljava/lang/String;", "GetGetDirectionHandler:Com.Tencent.Map.Geolocation.ITencentPoiInvoker, TencentMapBind")] get;
		}

		double Distance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentPoi']/method[@name='getDistance' and count(parameter)=0]"
			[Register ("getDistance", "()D", "GetGetDistanceHandler:Com.Tencent.Map.Geolocation.ITencentPoiInvoker, TencentMapBind")] get;
		}

		double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentPoi']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler:Com.Tencent.Map.Geolocation.ITencentPoiInvoker, TencentMapBind")] get;
		}

		double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentPoi']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler:Com.Tencent.Map.Geolocation.ITencentPoiInvoker, TencentMapBind")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentPoi']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Tencent.Map.Geolocation.ITencentPoiInvoker, TencentMapBind")] get;
		}

		string Uid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentPoi']/method[@name='getUid' and count(parameter)=0]"
			[Register ("getUid", "()Ljava/lang/String;", "GetGetUidHandler:Com.Tencent.Map.Geolocation.ITencentPoiInvoker, TencentMapBind")] get;
		}

	}

	[global::Android.Runtime.Register ("com/tencent/map/geolocation/TencentPoi", DoNotGenerateAcw=true)]
	internal class ITencentPoiInvoker : global::Java.Lang.Object, ITencentPoi {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/tencent/map/geolocation/TencentPoi", typeof (ITencentPoiInvoker));

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

		public static ITencentPoi GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITencentPoi> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.map.geolocation.TencentPoi"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITencentPoiInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentPoi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentPoi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Address);
		}
#pragma warning restore 0169

		IntPtr id_getAddress;
		public unsafe string Address {
			get {
				if (id_getAddress == IntPtr.Zero)
					id_getAddress = JNIEnv.GetMethodID (class_ref, "getAddress", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAddress), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCatalog;
#pragma warning disable 0169
		static Delegate GetGetCatalogHandler ()
		{
			if (cb_getCatalog == null)
				cb_getCatalog = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCatalog);
			return cb_getCatalog;
		}

		static IntPtr n_GetCatalog (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentPoi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentPoi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Catalog);
		}
#pragma warning restore 0169

		IntPtr id_getCatalog;
		public unsafe string Catalog {
			get {
				if (id_getCatalog == IntPtr.Zero)
					id_getCatalog = JNIEnv.GetMethodID (class_ref, "getCatalog", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCatalog), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDirection;
#pragma warning disable 0169
		static Delegate GetGetDirectionHandler ()
		{
			if (cb_getDirection == null)
				cb_getDirection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDirection);
			return cb_getDirection;
		}

		static IntPtr n_GetDirection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentPoi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentPoi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Direction);
		}
#pragma warning restore 0169

		IntPtr id_getDirection;
		public unsafe string Direction {
			get {
				if (id_getDirection == IntPtr.Zero)
					id_getDirection = JNIEnv.GetMethodID (class_ref, "getDirection", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDirection), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDistance;
#pragma warning disable 0169
		static Delegate GetGetDistanceHandler ()
		{
			if (cb_getDistance == null)
				cb_getDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetDistance);
			return cb_getDistance;
		}

		static double n_GetDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentPoi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentPoi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Distance;
		}
#pragma warning restore 0169

		IntPtr id_getDistance;
		public unsafe double Distance {
			get {
				if (id_getDistance == IntPtr.Zero)
					id_getDistance = JNIEnv.GetMethodID (class_ref, "getDistance", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDistance);
			}
		}

		static Delegate cb_getLatitude;
#pragma warning disable 0169
		static Delegate GetGetLatitudeHandler ()
		{
			if (cb_getLatitude == null)
				cb_getLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitude);
			return cb_getLatitude;
		}

		static double n_GetLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentPoi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentPoi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Latitude;
		}
#pragma warning restore 0169

		IntPtr id_getLatitude;
		public unsafe double Latitude {
			get {
				if (id_getLatitude == IntPtr.Zero)
					id_getLatitude = JNIEnv.GetMethodID (class_ref, "getLatitude", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getLatitude);
			}
		}

		static Delegate cb_getLongitude;
#pragma warning disable 0169
		static Delegate GetGetLongitudeHandler ()
		{
			if (cb_getLongitude == null)
				cb_getLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitude);
			return cb_getLongitude;
		}

		static double n_GetLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentPoi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentPoi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Longitude;
		}
#pragma warning restore 0169

		IntPtr id_getLongitude;
		public unsafe double Longitude {
			get {
				if (id_getLongitude == IntPtr.Zero)
					id_getLongitude = JNIEnv.GetMethodID (class_ref, "getLongitude", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getLongitude);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentPoi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentPoi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUid;
#pragma warning disable 0169
		static Delegate GetGetUidHandler ()
		{
			if (cb_getUid == null)
				cb_getUid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUid);
			return cb_getUid;
		}

		static IntPtr n_GetUid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentPoi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentPoi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uid);
		}
#pragma warning restore 0169

		IntPtr id_getUid;
		public unsafe string Uid {
			get {
				if (id_getUid == IntPtr.Zero)
					id_getUid = JNIEnv.GetMethodID (class_ref, "getUid", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUid), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
