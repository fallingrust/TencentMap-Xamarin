using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='UrlTileProvider']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/UrlTileProvider", DoNotGenerateAcw=true)]
	public abstract partial class UrlTileProvider : global::Java.Lang.Object, global::Com.Tencent.Mapsdk.Raster.Model.ITileProvider {


		public static class InterfaceConsts {

			// The following are fields from: com.tencent.mapsdk.raster.model.TileProvider


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/interface[@name='TileProvider']/field[@name='NO_TILE']"
			[Register ("NO_TILE")]
			public static global::Com.Tencent.Mapsdk.Raster.Model.Tile NoTile {
				get {
					const string __id = "NO_TILE.Lcom/tencent/mapsdk/raster/model/Tile;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Tile> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/mapsdk/raster/model/UrlTileProvider", typeof (UrlTileProvider));
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

		protected UrlTileProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='UrlTileProvider']/constructor[@name='UrlTileProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UrlTileProvider ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='UrlTileProvider']/method[@name='getTile' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.tencent.mapsdk.rastercore.tile.MapTile.MapSource'] and parameter[5][@type='java.lang.Object...']]"
		[Register ("getTile", "(IIILcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;[Ljava/lang/Object;)Lcom/tencent/mapsdk/raster/model/Tile;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.Tile GetTile (int p0, int p1, int p2, global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource p3, params global::Java.Lang.Object[] p4)
		{
			const string __id = "getTile.(IIILcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;[Ljava/lang/Object;)Lcom/tencent/mapsdk/raster/model/Tile;";
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Tile> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static Delegate cb_getTileUrl_IIIarrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetTileUrl_IIIarrayLjava_lang_Object_Handler ()
		{
			if (cb_getTileUrl_IIIarrayLjava_lang_Object_ == null)
				cb_getTileUrl_IIIarrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr, IntPtr>) n_GetTileUrl_IIIarrayLjava_lang_Object_);
			return cb_getTileUrl_IIIarrayLjava_lang_Object_;
		}

		static IntPtr n_GetTileUrl_IIIarrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.UrlTileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.UrlTileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTileUrl (p0, p1, p2, p3));
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='UrlTileProvider']/method[@name='getTileUrl' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("getTileUrl", "(III[Ljava/lang/Object;)Ljava/net/URL;", "GetGetTileUrl_IIIarrayLjava_lang_Object_Handler")]
		public abstract global::Java.Net.URL GetTileUrl (int p0, int p1, int p2, params global::Java.Lang.Object[] p3);

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
			global::Com.Tencent.Mapsdk.Raster.Model.UrlTileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.UrlTileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TileHeight;
		}
#pragma warning restore 0169

		public abstract int TileHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='UrlTileProvider']/method[@name='getTileHeight' and count(parameter)=0]"
			[Register ("getTileHeight", "()I", "GetGetTileHeightHandler")] get;
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
			global::Com.Tencent.Mapsdk.Raster.Model.UrlTileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.UrlTileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TileWidth;
		}
#pragma warning restore 0169

		public abstract int TileWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='UrlTileProvider']/method[@name='getTileWidth' and count(parameter)=0]"
			[Register ("getTileWidth", "()I", "GetGetTileWidthHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/UrlTileProvider", DoNotGenerateAcw=true)]
	internal partial class UrlTileProviderInvoker : UrlTileProvider {

		public UrlTileProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/tencent/mapsdk/raster/model/UrlTileProvider", typeof (UrlTileProviderInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='UrlTileProvider']/method[@name='getTileUrl' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("getTileUrl", "(III[Ljava/lang/Object;)Ljava/net/URL;", "GetGetTileUrl_IIIarrayLjava_lang_Object_Handler")]
		public override unsafe global::Java.Net.URL GetTileUrl (int p0, int p1, int p2, params global::Java.Lang.Object[] p3)
		{
			const string __id = "getTileUrl.(III[Ljava/lang/Object;)Ljava/net/URL;";
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		public override unsafe int TileHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='UrlTileProvider']/method[@name='getTileHeight' and count(parameter)=0]"
			[Register ("getTileHeight", "()I", "GetGetTileHeightHandler")]
			get {
				const string __id = "getTileHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe int TileWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='UrlTileProvider']/method[@name='getTileWidth' and count(parameter)=0]"
			[Register ("getTileWidth", "()I", "GetGetTileWidthHandler")]
			get {
				const string __id = "getTileWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}

}
