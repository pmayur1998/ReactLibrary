using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Newcustomlibrary.RNNewcustomlibrary
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNNewcustomlibraryModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNNewcustomlibraryModule"/>.
        /// </summary>
        internal RNNewcustomlibraryModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNNewcustomlibrary";
            }
        }
    }
}
