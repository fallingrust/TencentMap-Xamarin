using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TileOverlayOptions']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/TileOverlayOptions", DoNotGenerateAcw=true)]
	public sealed partial class TileOverlayOptions : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/mapsdk/raster/model/TileOverlayOptions", typeof (TileOverlayOptions));
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

		internal TileOverlayOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TileOverlayOptions']/constructor[@name='TileOverlayOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TileOverlayOptions ()
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

		public unsafe bool DiskCacheEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TileOverlayOptions']/method[@name='getDiskCacheEnabled' and count(parameter)=0]"
			[Register ("getDiskCacheEnabled", "()Z", "GetGetDiskCacheEnabledHandler")]
			get {
				const string __id = "getDiskCacheEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TileOverlayOptions']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				const string __id = "isVisible.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.ITileProvider TileProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TileOverlayOptions']/method[@name='getTileProvider' and count(parameter)=0]"
			[Register ("getTileProvider", "()Lcom/tencent/mapsdk/raster/model/TileProvider;", "GetGetTileProviderHandler")]
			get {
				const string __id = "getTileProvider.()Lcom/tencent/mapsdk/raster/model/TileProvider;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.ITileProvider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TileOverlayOptions']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				const string __id = "getZIndex.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TileOverlayOptions']/method[@name='diskCacheEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("diskCacheEnabled", "(Z)Lcom/tencent/mapsdk/raster/model/TileOverlayOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.TileOverlayOptions InvokeDiskCacheEnabled (bool p0)
		{
			const string __id = "diskCacheEnabled.(Z)Lcom/tencent/mapsdk/raster/model/TileOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.TileOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TileOverlayOptions']/method[@name='tileProvider' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.TileProvider']]"
		[Register ("tileProvider", "(Lcom/tencent/mapsdk/raster/model/TileProvider;)Lcom/tencent/mapsdk/raster/model/TileOverlayOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.TileOverlayOptions InvokeTileProvider (global::Com.Tencent.Mapsdk.Raster.Model.ITileProvider p0)
		{
			const string __id = "tileProvider.(Lcom/tencent/mapsdk/raster/model/TileProvider;)Lcom/tencent/mapsdk/raster/model/TileOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.TileOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TileOverlayOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/tencent/mapsdk/raster/model/TileOverlayOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.TileOverlayOptions Visible (bool p0)
		{
			const string __id = "visible.(Z)Lcom/tencent/mapsdk/raster/model/TileOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.TileOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='TileOverlayOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zIndex", "(F)Lcom/tencent/mapsdk/raster/model/TileOverlayOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.TileOverlayOptions InvokeZIndex (float p0)
		{
			const string __id = "zIndex.(F)Lcom/tencent/mapsdk/raster/model/TileOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.TileOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
