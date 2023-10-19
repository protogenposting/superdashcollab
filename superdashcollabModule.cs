using System;
using Microsoft.Xna.Framework;

namespace Celeste.Mod.superdashcollab {
    public class superdashcollabModule : EverestModule {
        public static superdashcollabModule Instance { get; private set; }

        public override Type SettingsType => typeof(superdashcollabModuleSettings);
        public static superdashcollabModuleSettings Settings => (superdashcollabModuleSettings) Instance._Settings;

        public override Type SessionType => typeof(superdashcollabModuleSession);
        public static superdashcollabModuleSession Session => (superdashcollabModuleSession) Instance._Session;

        public superdashcollabModule() {
            Instance = this;
#if DEBUG
            // debug builds use verbose logging
            Logger.SetLogLevel(nameof(superdashcollabModule), LogLevel.Verbose);
#else
            // release builds use info logging to reduce spam in log files
            Logger.SetLogLevel(nameof(superdashcollabModule), LogLevel.Info);
#endif
        }

        public override void Load() {
            // TODO: apply any hooks that should always be active
        }

        public override void Unload() {
            // TODO: unapply any hooks applied in Load()
        }
    }
}