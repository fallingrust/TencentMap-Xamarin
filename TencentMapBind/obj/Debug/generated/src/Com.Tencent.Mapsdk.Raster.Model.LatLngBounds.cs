using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/LatLngBounds", DoNotGenerateAcw=true)]
	public partial class LatLngBounds : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds.Builder']"
		[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/LatLngBounds$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/mapsdk/raster/model/LatLngBounds$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds.Builder']/constructor[@name='LatLngBounds.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/tencent/mapsdk/raster/model/LatLngBounds;", "")]
			public unsafe global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds Build ()
			{
				const string __id = "build.()Lcom/tencent/mapsdk/raster/model/LatLngBounds;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds.Builder']/method[@name='include' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
			[Register ("include", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/LatLngBounds$Builder;", "")]
			public unsafe global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds.Builder Include (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
			{
				const string __id = "include.(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/LatLngBounds$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds.Builder']/method[@name='include' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;com.tencent.mapsdk.raster.model.LatLng&gt;']]"
			[Register ("include", "(Ljava/lang/Iterable;)Lcom/tencent/mapsdk/raster/model/LatLngBounds$Builder;", "")]
			public unsafe global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds.Builder Include (global::Java.Lang.IIterable p0)
			{
				const string __id = "include.(Ljava/lang/Iterable;)Lcom/tencent/mapsdk/raster/model/LatLngBounds$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/mapsdk/raster/model/LatLngBounds", typeof (LatLngBounds));
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

		protected LatLngBounds (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/constructor[@name='LatLngBounds' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register (".ctor", "(Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)V", "")]
		public unsafe LatLngBounds (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, global::Com.Tencent.Mapsdk.Raster.Model.LatLng p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getNortheast;
#pragma warning disable 0169
		static Delegate GetGetNortheastHandler ()
		{
			if (cb_getNortheast == null)
				cb_getNortheast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNortheast);
			return cb_getNortheast;
		}

		static IntPtr n_GetNortheast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Northeast);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.LatLng Northeast {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='getNortheast' and count(parameter)=0]"
			[Register ("getNortheast", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetNortheastHandler")]
			get {
				const string __id = "getNortheast.()Lcom/tencent/mapsdk/raster/model/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSouthwest;
#pragma warning disable 0169
		static Delegate GetGetSouthwestHandler ()
		{
			if (cb_getSouthwest == null)
				cb_getSouthwest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSouthwest);
			return cb_getSouthwest;
		}

		static IntPtr n_GetSouthwest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Southwest);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.LatLng Southwest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='getSouthwest' and count(parameter)=0]"
			[Register ("getSouthwest", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetSouthwestHandler")]
			get {
				const string __id = "getSouthwest.()Lcom/tencent/mapsdk/raster/model/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lcom/tencent/mapsdk/raster/model/LatLngBounds$Builder;", "")]
		public static unsafe global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds.Builder InvokeBuilder ()
		{
			const string __id = "builder.()Lcom/tencent/mapsdk/raster/model/LatLngBounds$Builder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_contains_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetContains_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_contains_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_contains_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_contains_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static bool n_Contains_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("contains", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Z", "GetContains_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
		public virtual unsafe bool Contains (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			const string __id = "contains.(Lcom/tencent/mapsdk/raster/model/LatLng;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_;
#pragma warning disable 0169
		static Delegate GetContains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_Handler ()
		{
			if (cb_contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ == null)
				cb_contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_);
			return cb_contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_;
		}

		static bool n_Contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLngBounds']]"
		[Register ("contains", "(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)Z", "GetContains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_Handler")]
		public virtual unsafe bool Contains (global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds p0)
		{
			const string __id = "contains.(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_including_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetIncluding_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_including_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_including_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Including_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_including_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static IntPtr n_Including_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Including (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='including' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("including", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/LatLngBounds;", "GetIncluding_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds Including (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			const string __id = "including.(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/LatLngBounds;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_;
#pragma warning disable 0169
		static Delegate GetIntersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_Handler ()
		{
			if (cb_intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ == null)
				cb_intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_);
			return cb_intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_;
		}

		static bool n_Intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Intersects (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='intersects' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLngBounds']]"
		[Register ("intersects", "(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)Z", "GetIntersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_Handler")]
		public virtual unsafe bool Intersects (global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds p0)
		{
			const string __id = "intersects.(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
