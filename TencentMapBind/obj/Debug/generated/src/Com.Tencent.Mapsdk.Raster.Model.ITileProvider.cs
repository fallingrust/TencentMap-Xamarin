using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Mapsdk.Raster.Model {

	[Register ("com/tencent/mapsdk/raster/model/TileProvider", DoNotGenerateAcw=true)]
	public abstract class TileProvider : Java.Lang.Object {

		internal TileProvider ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/interface[@name='TileProvider']/field[@name='NO_TILE']"
		[Register ("NO_TILE")]
		public static global::Com.Tencent.Mapsdk.Raster.Model.Tile NoTile {
			get {
				const string __id = "NO_TILE.Lcom/tencent/mapsdk/raster/model/Tile;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Tile> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		new static JniPeerMembers _members = new JniPeerMembers ("com/tencent/mapsdk/raster/model/TileProvider", typeof (TileProvider));
	}

	[Register ("com/tencent/mapsdk/raster/model/TileProvider", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'TileProvider' type. This type will be removed in a future release.")]
	public abstract class TileProviderConsts : TileProvider {

		private TileProviderConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/interface[@name='TileProvider']"
	[Register ("com/tencent/mapsdk/raster/model/TileProvider", "", "Com.Tencent.Mapsdk.Raster.Model.ITileProviderInvoker")]
	public partial interface ITileProvider : IJavaObject {

		int TileHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/interface[@name='TileProvider']/method[@name='getTileHeight' and count(parameter)=0]"
			[Register ("getTileHeight", "()I", "GetGetTileHeightHandler:Com.Tencent.Mapsdk.Raster.Model.ITileProviderInvoker, TencentMapBind")] get;
		}

		int TileWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/interface[@name='TileProvider']/method[@name='getTileWidth' and count(parameter)=0]"
			[Register ("getTileWidth", "()I", "GetGetTileWidthHandler:Com.Tencent.Mapsdk.Raster.Model.ITileProviderInvoker, TencentMapBind")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/interface[@name='TileProvider']/method[@name='getTile' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.tencent.mapsdk.rastercore.tile.MapTile.MapSource'] and parameter[5][@type='java.lang.Object...']]"
		[Register ("getTile", "(IIILcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;[Ljava/lang/Object;)Lcom/tencent/mapsdk/raster/model/Tile;", "GetGetTile_IIILcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_arrayLjava_lang_Object_Handler:Com.Tencent.Mapsdk.Raster.Model.ITileProviderInvoker, TencentMapBind")]
		global::Com.Tencent.Mapsdk.Raster.Model.Tile GetTile (int p0, int p1, int p2, global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource p3, params global::Java.Lang.Object[] p4);

	}

	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/TileProvider", DoNotGenerateAcw=true)]
	internal class ITileProviderInvoker : global::Java.Lang.Object, ITileProvider {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/tencent/mapsdk/raster/model/TileProvider", typeof (ITileProviderInvoker));

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

		public static ITileProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITileProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.mapsdk.raster.model.TileProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITileProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getTileHeight;
#pragma warning disable 0169
		static Delegate GetGetTileHeightHandler ()
		{
			if (cb_getTileHeight == null)
				cb_getTileHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTileHeight);
			return cb_getTileHeight;
		}

		static int n_GetTileHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.ITileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.ITileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TileHeight;
		}
#pragma warning restore 0169

		IntPtr id_getTileHeight;
		public unsafe int TileHeight {
			get {
				if (id_getTileHeight == IntPtr.Zero)
					id_getTileHeight = JNIEnv.GetMethodID (class_ref, "getTileHeight", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTileHeight);
			}
		}

		static Delegate cb_getTileWidth;
#pragma warning disable 0169
		static Delegate GetGetTileWidthHandler ()
		{
			if (cb_getTileWidth == null)
				cb_getTileWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTileWidth);
			return cb_getTileWidth;
		}

		static int n_GetTileWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.ITileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.ITileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TileWidth;
		}
#pragma warning restore 0169

		IntPtr id_getTileWidth;
		public unsafe int TileWidth {
			get {
				if (id_getTileWidth == IntPtr.Zero)
					id_getTileWidth = JNIEnv.GetMethodID (class_ref, "getTileWidth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTileWidth);
			}
		}

		static Delegate cb_getTile_IIILcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetTile_IIILcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_arrayLjava_lang_Object_Handler ()
		{
			if (cb_getTile_IIILcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_arrayLjava_lang_Object_ == null)
				cb_getTile_IIILcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr, IntPtr, IntPtr>) n_GetTile_IIILcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_arrayLjava_lang_Object_);
			return cb_getTile_IIILcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_arrayLjava_lang_Object_;
		}

		static IntPtr n_GetTile_IIILcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.ITileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.ITileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource p3 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p4 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTile (p0, p1, p2, p3, p4));
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getTile_IIILcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_arrayLjava_lang_Object_;
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.Tile GetTile (int p0, int p1, int p2, global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource p3, params global::Java.Lang.Object[] p4)
		{
			if (id_getTile_IIILcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getTile_IIILcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getTile", "(IIILcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;[Ljava/lang/Object;)Lcom/tencent/mapsdk/raster/model/Tile;");
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue (native_p4);
			global::Com.Tencent.Mapsdk.Raster.Model.Tile __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Tile> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTile_IIILcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

	}

}
