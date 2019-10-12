using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Map.Geolocation {

	[Register ("com/tencent/map/geolocation/TencentLocation", DoNotGenerateAcw=true)]
	public abstract class TencentLocation : Java.Lang.Object {

		internal TencentLocation ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/field[@name='ERROR_BAD_JSON']"
		[Register ("ERROR_BAD_JSON")]
		public const int ErrorBadJson = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/field[@name='ERROR_NETWORK']"
		[Register ("ERROR_NETWORK")]
		public const int ErrorNetwork = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/field[@name='ERROR_OK']"
		[Register ("ERROR_OK")]
		public const int ErrorOk = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/field[@name='ERROR_UNKNOWN']"
		[Register ("ERROR_UNKNOWN")]
		public const int ErrorUnknown = (int) 404;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/field[@name='ERROR_WGS84']"
		[Register ("ERROR_WGS84")]
		public const int ErrorWgs84 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/field[@name='EXTRA_ADDRDESP_LANDMARK']"
		[Register ("EXTRA_ADDRDESP_LANDMARK")]
		public const string ExtraAddrdespLandmark = (string) "addrdesp.landmark";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/field[@name='EXTRA_ADDRDESP_OTHERS_RESULTS']"
		[Register ("EXTRA_ADDRDESP_OTHERS_RESULTS")]
		public const string ExtraAddrdespOthersResults = (string) "addrdesp.results";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/field[@name='EXTRA_ADDRDESP_SECOND_LANDMARK']"
		[Register ("EXTRA_ADDRDESP_SECOND_LANDMARK")]
		public const string ExtraAddrdespSecondLandmark = (string) "addrdesp.second_landmark";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/field[@name='EXTRA_DIRECTION']"
		[Register ("EXTRA_DIRECTION")]
		public const string ExtraDirection = (string) "direction";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/field[@name='EXTRA_RESP_JSON']"
		[Register ("EXTRA_RESP_JSON")]
		public const string ExtraRespJson = (string) "resp_json";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/field[@name='GPS_PROVIDER']"
		[Register ("GPS_PROVIDER")]
		public const string GpsProvider = (string) "gps";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/field[@name='NETWORK_PROVIDER']"
		[Register ("NETWORK_PROVIDER")]
		public const string NetworkProvider = (string) "network";
	}

	[Register ("com/tencent/map/geolocation/TencentLocation", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'TencentLocation' type. This type will be removed in a future release.")]
	public abstract class TencentLocationConsts : TencentLocation {

		private TencentLocationConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']"
	[Register ("com/tencent/map/geolocation/TencentLocation", "", "Com.Tencent.Map.Geolocation.ITencentLocationInvoker")]
	public partial interface ITencentLocation : IJavaObject {

		float Accuracy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getAccuracy' and count(parameter)=0]"
			[Register ("getAccuracy", "()F", "GetGetAccuracyHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Ljava/lang/String;", "GetGetAddressHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		double Altitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getAltitude' and count(parameter)=0]"
			[Register ("getAltitude", "()D", "GetGetAltitudeHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		global::Java.Lang.Integer AreaStat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getAreaStat' and count(parameter)=0]"
			[Register ("getAreaStat", "()Ljava/lang/Integer;", "GetGetAreaStatHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		float Bearing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getBearing' and count(parameter)=0]"
			[Register ("getBearing", "()F", "GetGetBearingHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		string City {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getCity' and count(parameter)=0]"
			[Register ("getCity", "()Ljava/lang/String;", "GetGetCityHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		string CityCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getCityCode' and count(parameter)=0]"
			[Register ("getCityCode", "()Ljava/lang/String;", "GetGetCityCodeHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		string CityPhoneCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getCityPhoneCode' and count(parameter)=0]"
			[Register ("getCityPhoneCode", "()Ljava/lang/String;", "GetGetCityPhoneCodeHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		int CoordinateType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getCoordinateType' and count(parameter)=0]"
			[Register ("getCoordinateType", "()I", "GetGetCoordinateTypeHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		double Direction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getDirection' and count(parameter)=0]"
			[Register ("getDirection", "()D", "GetGetDirectionHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		string District {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getDistrict' and count(parameter)=0]"
			[Register ("getDistrict", "()Ljava/lang/String;", "GetGetDistrictHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		long ElapsedRealtime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getElapsedRealtime' and count(parameter)=0]"
			[Register ("getElapsedRealtime", "()J", "GetGetElapsedRealtimeHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		global::Android.OS.Bundle Extra {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getExtra' and count(parameter)=0]"
			[Register ("getExtra", "()Landroid/os/Bundle;", "GetGetExtraHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		int GPSRssi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getGPSRssi' and count(parameter)=0]"
			[Register ("getGPSRssi", "()I", "GetGetGPSRssiHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		string IndoorBuildingFloor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getIndoorBuildingFloor' and count(parameter)=0]"
			[Register ("getIndoorBuildingFloor", "()Ljava/lang/String;", "GetGetIndoorBuildingFloorHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		string IndoorBuildingId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getIndoorBuildingId' and count(parameter)=0]"
			[Register ("getIndoorBuildingId", "()Ljava/lang/String;", "GetGetIndoorBuildingIdHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		int IndoorLocationType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getIndoorLocationType' and count(parameter)=0]"
			[Register ("getIndoorLocationType", "()I", "GetGetIndoorLocationTypeHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		string Nation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getNation' and count(parameter)=0]"
			[Register ("getNation", "()Ljava/lang/String;", "GetGetNationHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		global::System.Collections.Generic.IList<global::Com.Tencent.Map.Geolocation.ITencentPoi> PoiList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getPoiList' and count(parameter)=0]"
			[Register ("getPoiList", "()Ljava/util/List;", "GetGetPoiListHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		string Provider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getProvider' and count(parameter)=0]"
			[Register ("getProvider", "()Ljava/lang/String;", "GetGetProviderHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		string Province {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getProvince' and count(parameter)=0]"
			[Register ("getProvince", "()Ljava/lang/String;", "GetGetProvinceHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		float Speed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getSpeed' and count(parameter)=0]"
			[Register ("getSpeed", "()F", "GetGetSpeedHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		string Street {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getStreet' and count(parameter)=0]"
			[Register ("getStreet", "()Ljava/lang/String;", "GetGetStreetHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		string StreetNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getStreetNo' and count(parameter)=0]"
			[Register ("getStreetNo", "()Ljava/lang/String;", "GetGetStreetNoHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		long Time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getTime' and count(parameter)=0]"
			[Register ("getTime", "()J", "GetGetTimeHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		string Town {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getTown' and count(parameter)=0]"
			[Register ("getTown", "()Ljava/lang/String;", "GetGetTownHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		string Village {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='getVillage' and count(parameter)=0]"
			[Register ("getVillage", "()Ljava/lang/String;", "GetGetVillageHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/interface[@name='TencentLocation']/method[@name='isMockGps' and count(parameter)=0]"
		[Register ("isMockGps", "()I", "GetIsMockGpsHandler:Com.Tencent.Map.Geolocation.ITencentLocationInvoker, TencentMapBind")]
		int IsMockGps ();

	}

	[global::Android.Runtime.Register ("com/tencent/map/geolocation/TencentLocation", DoNotGenerateAcw=true)]
	internal class ITencentLocationInvoker : global::Java.Lang.Object, ITencentLocation {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/tencent/map/geolocation/TencentLocation", typeof (ITencentLocationInvoker));

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

		public static ITencentLocation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITencentLocation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.map.geolocation.TencentLocation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITencentLocationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAccuracy;
#pragma warning disable 0169
		static Delegate GetGetAccuracyHandler ()
		{
			if (cb_getAccuracy == null)
				cb_getAccuracy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAccuracy);
			return cb_getAccuracy;
		}

		static float n_GetAccuracy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Accuracy;
		}
#pragma warning restore 0169

		IntPtr id_getAccuracy;
		public unsafe float Accuracy {
			get {
				if (id_getAccuracy == IntPtr.Zero)
					id_getAccuracy = JNIEnv.GetMethodID (class_ref, "getAccuracy", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getAccuracy);
			}
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
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getAltitude;
#pragma warning disable 0169
		static Delegate GetGetAltitudeHandler ()
		{
			if (cb_getAltitude == null)
				cb_getAltitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetAltitude);
			return cb_getAltitude;
		}

		static double n_GetAltitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Altitude;
		}
#pragma warning restore 0169

		IntPtr id_getAltitude;
		public unsafe double Altitude {
			get {
				if (id_getAltitude == IntPtr.Zero)
					id_getAltitude = JNIEnv.GetMethodID (class_ref, "getAltitude", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getAltitude);
			}
		}

		static Delegate cb_getAreaStat;
#pragma warning disable 0169
		static Delegate GetGetAreaStatHandler ()
		{
			if (cb_getAreaStat == null)
				cb_getAreaStat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAreaStat);
			return cb_getAreaStat;
		}

		static IntPtr n_GetAreaStat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AreaStat);
		}
#pragma warning restore 0169

		IntPtr id_getAreaStat;
		public unsafe global::Java.Lang.Integer AreaStat {
			get {
				if (id_getAreaStat == IntPtr.Zero)
					id_getAreaStat = JNIEnv.GetMethodID (class_ref, "getAreaStat", "()Ljava/lang/Integer;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAreaStat), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBearing;
#pragma warning disable 0169
		static Delegate GetGetBearingHandler ()
		{
			if (cb_getBearing == null)
				cb_getBearing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBearing);
			return cb_getBearing;
		}

		static float n_GetBearing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bearing;
		}
#pragma warning restore 0169

		IntPtr id_getBearing;
		public unsafe float Bearing {
			get {
				if (id_getBearing == IntPtr.Zero)
					id_getBearing = JNIEnv.GetMethodID (class_ref, "getBearing", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getBearing);
			}
		}

		static Delegate cb_getCity;
#pragma warning disable 0169
		static Delegate GetGetCityHandler ()
		{
			if (cb_getCity == null)
				cb_getCity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCity);
			return cb_getCity;
		}

		static IntPtr n_GetCity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.City);
		}
#pragma warning restore 0169

		IntPtr id_getCity;
		public unsafe string City {
			get {
				if (id_getCity == IntPtr.Zero)
					id_getCity = JNIEnv.GetMethodID (class_ref, "getCity", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCity), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCityCode;
#pragma warning disable 0169
		static Delegate GetGetCityCodeHandler ()
		{
			if (cb_getCityCode == null)
				cb_getCityCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCityCode);
			return cb_getCityCode;
		}

		static IntPtr n_GetCityCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CityCode);
		}
#pragma warning restore 0169

		IntPtr id_getCityCode;
		public unsafe string CityCode {
			get {
				if (id_getCityCode == IntPtr.Zero)
					id_getCityCode = JNIEnv.GetMethodID (class_ref, "getCityCode", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCityCode), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCityPhoneCode;
#pragma warning disable 0169
		static Delegate GetGetCityPhoneCodeHandler ()
		{
			if (cb_getCityPhoneCode == null)
				cb_getCityPhoneCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCityPhoneCode);
			return cb_getCityPhoneCode;
		}

		static IntPtr n_GetCityPhoneCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CityPhoneCode);
		}
#pragma warning restore 0169

		IntPtr id_getCityPhoneCode;
		public unsafe string CityPhoneCode {
			get {
				if (id_getCityPhoneCode == IntPtr.Zero)
					id_getCityPhoneCode = JNIEnv.GetMethodID (class_ref, "getCityPhoneCode", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCityPhoneCode), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCoordinateType;
#pragma warning disable 0169
		static Delegate GetGetCoordinateTypeHandler ()
		{
			if (cb_getCoordinateType == null)
				cb_getCoordinateType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCoordinateType);
			return cb_getCoordinateType;
		}

		static int n_GetCoordinateType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CoordinateType;
		}
#pragma warning restore 0169

		IntPtr id_getCoordinateType;
		public unsafe int CoordinateType {
			get {
				if (id_getCoordinateType == IntPtr.Zero)
					id_getCoordinateType = JNIEnv.GetMethodID (class_ref, "getCoordinateType", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCoordinateType);
			}
		}

		static Delegate cb_getDirection;
#pragma warning disable 0169
		static Delegate GetGetDirectionHandler ()
		{
			if (cb_getDirection == null)
				cb_getDirection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetDirection);
			return cb_getDirection;
		}

		static double n_GetDirection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Direction;
		}
#pragma warning restore 0169

		IntPtr id_getDirection;
		public unsafe double Direction {
			get {
				if (id_getDirection == IntPtr.Zero)
					id_getDirection = JNIEnv.GetMethodID (class_ref, "getDirection", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDirection);
			}
		}

		static Delegate cb_getDistrict;
#pragma warning disable 0169
		static Delegate GetGetDistrictHandler ()
		{
			if (cb_getDistrict == null)
				cb_getDistrict = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDistrict);
			return cb_getDistrict;
		}

		static IntPtr n_GetDistrict (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.District);
		}
#pragma warning restore 0169

		IntPtr id_getDistrict;
		public unsafe string District {
			get {
				if (id_getDistrict == IntPtr.Zero)
					id_getDistrict = JNIEnv.GetMethodID (class_ref, "getDistrict", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDistrict), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getElapsedRealtime;
#pragma warning disable 0169
		static Delegate GetGetElapsedRealtimeHandler ()
		{
			if (cb_getElapsedRealtime == null)
				cb_getElapsedRealtime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetElapsedRealtime);
			return cb_getElapsedRealtime;
		}

		static long n_GetElapsedRealtime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ElapsedRealtime;
		}
#pragma warning restore 0169

		IntPtr id_getElapsedRealtime;
		public unsafe long ElapsedRealtime {
			get {
				if (id_getElapsedRealtime == IntPtr.Zero)
					id_getElapsedRealtime = JNIEnv.GetMethodID (class_ref, "getElapsedRealtime", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getElapsedRealtime);
			}
		}

		static Delegate cb_getExtra;
#pragma warning disable 0169
		static Delegate GetGetExtraHandler ()
		{
			if (cb_getExtra == null)
				cb_getExtra = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtra);
			return cb_getExtra;
		}

		static IntPtr n_GetExtra (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Extra);
		}
#pragma warning restore 0169

		IntPtr id_getExtra;
		public unsafe global::Android.OS.Bundle Extra {
			get {
				if (id_getExtra == IntPtr.Zero)
					id_getExtra = JNIEnv.GetMethodID (class_ref, "getExtra", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtra), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getGPSRssi;
#pragma warning disable 0169
		static Delegate GetGetGPSRssiHandler ()
		{
			if (cb_getGPSRssi == null)
				cb_getGPSRssi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGPSRssi);
			return cb_getGPSRssi;
		}

		static int n_GetGPSRssi (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GPSRssi;
		}
#pragma warning restore 0169

		IntPtr id_getGPSRssi;
		public unsafe int GPSRssi {
			get {
				if (id_getGPSRssi == IntPtr.Zero)
					id_getGPSRssi = JNIEnv.GetMethodID (class_ref, "getGPSRssi", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getGPSRssi);
			}
		}

		static Delegate cb_getIndoorBuildingFloor;
#pragma warning disable 0169
		static Delegate GetGetIndoorBuildingFloorHandler ()
		{
			if (cb_getIndoorBuildingFloor == null)
				cb_getIndoorBuildingFloor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIndoorBuildingFloor);
			return cb_getIndoorBuildingFloor;
		}

		static IntPtr n_GetIndoorBuildingFloor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IndoorBuildingFloor);
		}
#pragma warning restore 0169

		IntPtr id_getIndoorBuildingFloor;
		public unsafe string IndoorBuildingFloor {
			get {
				if (id_getIndoorBuildingFloor == IntPtr.Zero)
					id_getIndoorBuildingFloor = JNIEnv.GetMethodID (class_ref, "getIndoorBuildingFloor", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIndoorBuildingFloor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIndoorBuildingId;
#pragma warning disable 0169
		static Delegate GetGetIndoorBuildingIdHandler ()
		{
			if (cb_getIndoorBuildingId == null)
				cb_getIndoorBuildingId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIndoorBuildingId);
			return cb_getIndoorBuildingId;
		}

		static IntPtr n_GetIndoorBuildingId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IndoorBuildingId);
		}
#pragma warning restore 0169

		IntPtr id_getIndoorBuildingId;
		public unsafe string IndoorBuildingId {
			get {
				if (id_getIndoorBuildingId == IntPtr.Zero)
					id_getIndoorBuildingId = JNIEnv.GetMethodID (class_ref, "getIndoorBuildingId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIndoorBuildingId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIndoorLocationType;
#pragma warning disable 0169
		static Delegate GetGetIndoorLocationTypeHandler ()
		{
			if (cb_getIndoorLocationType == null)
				cb_getIndoorLocationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndoorLocationType);
			return cb_getIndoorLocationType;
		}

		static int n_GetIndoorLocationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndoorLocationType;
		}
#pragma warning restore 0169

		IntPtr id_getIndoorLocationType;
		public unsafe int IndoorLocationType {
			get {
				if (id_getIndoorLocationType == IntPtr.Zero)
					id_getIndoorLocationType = JNIEnv.GetMethodID (class_ref, "getIndoorLocationType", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndoorLocationType);
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
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getNation;
#pragma warning disable 0169
		static Delegate GetGetNationHandler ()
		{
			if (cb_getNation == null)
				cb_getNation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNation);
			return cb_getNation;
		}

		static IntPtr n_GetNation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Nation);
		}
#pragma warning restore 0169

		IntPtr id_getNation;
		public unsafe string Nation {
			get {
				if (id_getNation == IntPtr.Zero)
					id_getNation = JNIEnv.GetMethodID (class_ref, "getNation", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPoiList;
#pragma warning disable 0169
		static Delegate GetGetPoiListHandler ()
		{
			if (cb_getPoiList == null)
				cb_getPoiList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoiList);
			return cb_getPoiList;
		}

		static IntPtr n_GetPoiList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Tencent.Map.Geolocation.ITencentPoi>.ToLocalJniHandle (__this.PoiList);
		}
#pragma warning restore 0169

		IntPtr id_getPoiList;
		public unsafe global::System.Collections.Generic.IList<global::Com.Tencent.Map.Geolocation.ITencentPoi> PoiList {
			get {
				if (id_getPoiList == IntPtr.Zero)
					id_getPoiList = JNIEnv.GetMethodID (class_ref, "getPoiList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Tencent.Map.Geolocation.ITencentPoi>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPoiList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getProvider;
#pragma warning disable 0169
		static Delegate GetGetProviderHandler ()
		{
			if (cb_getProvider == null)
				cb_getProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProvider);
			return cb_getProvider;
		}

		static IntPtr n_GetProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Provider);
		}
#pragma warning restore 0169

		IntPtr id_getProvider;
		public unsafe string Provider {
			get {
				if (id_getProvider == IntPtr.Zero)
					id_getProvider = JNIEnv.GetMethodID (class_ref, "getProvider", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getProvince;
#pragma warning disable 0169
		static Delegate GetGetProvinceHandler ()
		{
			if (cb_getProvince == null)
				cb_getProvince = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProvince);
			return cb_getProvince;
		}

		static IntPtr n_GetProvince (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Province);
		}
#pragma warning restore 0169

		IntPtr id_getProvince;
		public unsafe string Province {
			get {
				if (id_getProvince == IntPtr.Zero)
					id_getProvince = JNIEnv.GetMethodID (class_ref, "getProvince", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProvince), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSpeed;
#pragma warning disable 0169
		static Delegate GetGetSpeedHandler ()
		{
			if (cb_getSpeed == null)
				cb_getSpeed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetSpeed);
			return cb_getSpeed;
		}

		static float n_GetSpeed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Speed;
		}
#pragma warning restore 0169

		IntPtr id_getSpeed;
		public unsafe float Speed {
			get {
				if (id_getSpeed == IntPtr.Zero)
					id_getSpeed = JNIEnv.GetMethodID (class_ref, "getSpeed", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getSpeed);
			}
		}

		static Delegate cb_getStreet;
#pragma warning disable 0169
		static Delegate GetGetStreetHandler ()
		{
			if (cb_getStreet == null)
				cb_getStreet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreet);
			return cb_getStreet;
		}

		static IntPtr n_GetStreet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Street);
		}
#pragma warning restore 0169

		IntPtr id_getStreet;
		public unsafe string Street {
			get {
				if (id_getStreet == IntPtr.Zero)
					id_getStreet = JNIEnv.GetMethodID (class_ref, "getStreet", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStreet), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStreetNo;
#pragma warning disable 0169
		static Delegate GetGetStreetNoHandler ()
		{
			if (cb_getStreetNo == null)
				cb_getStreetNo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreetNo);
			return cb_getStreetNo;
		}

		static IntPtr n_GetStreetNo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StreetNo);
		}
#pragma warning restore 0169

		IntPtr id_getStreetNo;
		public unsafe string StreetNo {
			get {
				if (id_getStreetNo == IntPtr.Zero)
					id_getStreetNo = JNIEnv.GetMethodID (class_ref, "getStreetNo", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStreetNo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTime;
#pragma warning disable 0169
		static Delegate GetGetTimeHandler ()
		{
			if (cb_getTime == null)
				cb_getTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTime);
			return cb_getTime;
		}

		static long n_GetTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Time;
		}
#pragma warning restore 0169

		IntPtr id_getTime;
		public unsafe long Time {
			get {
				if (id_getTime == IntPtr.Zero)
					id_getTime = JNIEnv.GetMethodID (class_ref, "getTime", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTime);
			}
		}

		static Delegate cb_getTown;
#pragma warning disable 0169
		static Delegate GetGetTownHandler ()
		{
			if (cb_getTown == null)
				cb_getTown = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTown);
			return cb_getTown;
		}

		static IntPtr n_GetTown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Town);
		}
#pragma warning restore 0169

		IntPtr id_getTown;
		public unsafe string Town {
			get {
				if (id_getTown == IntPtr.Zero)
					id_getTown = JNIEnv.GetMethodID (class_ref, "getTown", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTown), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getVillage;
#pragma warning disable 0169
		static Delegate GetGetVillageHandler ()
		{
			if (cb_getVillage == null)
				cb_getVillage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVillage);
			return cb_getVillage;
		}

		static IntPtr n_GetVillage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Village);
		}
#pragma warning restore 0169

		IntPtr id_getVillage;
		public unsafe string Village {
			get {
				if (id_getVillage == IntPtr.Zero)
					id_getVillage = JNIEnv.GetMethodID (class_ref, "getVillage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVillage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isMockGps;
#pragma warning disable 0169
		static Delegate GetIsMockGpsHandler ()
		{
			if (cb_isMockGps == null)
				cb_isMockGps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IsMockGps);
			return cb_isMockGps;
		}

		static int n_IsMockGps (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Map.Geolocation.ITencentLocation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMockGps ();
		}
#pragma warning restore 0169

		IntPtr id_isMockGps;
		public unsafe int IsMockGps ()
		{
			if (id_isMockGps == IntPtr.Zero)
				id_isMockGps = JNIEnv.GetMethodID (class_ref, "isMockGps", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_isMockGps);
		}

	}

}
