using System.Linq;
using System.Collections.Generic;
class Layout {
    private Dictionary<Key, Key> remaps = new Dictionary<Key, Key>();
    private Dictionary<string,KeyMacro> macros = new Dictionary<string,KeyMacro>();

    public IEnumerable<KeyRemap> Remaps {
        get {
            return remaps.Select(_ => new KeyRemap{PhysicalKey = _.Key, MappedToKey = _.Value});
        }
        set {
            remaps = value.ToDictionary(_ => _.PhysicalKey, _ => _.MappedToKey);
        }
    }

    private string MacroKeyName(KeyMacro macro){
        return $"{macro.TriggerKey.KeyName};{macro.CoTrigger.KeyName}";
    }

    public IEnumerable<KeyMacro> Macros {
        get {
            return macros.Select(_ => _.Value).ToArray();
        }
        set {
            macros = value.ToDictionary(_ => MacroKeyName(_));
        }
    }

    public void AddOrUpdateRemap(KeyRemap remap){
        var newremaps = remaps.Where(_ => _.Key != remap.PhysicalKey);
        newremaps = newremaps.Append(new KeyValuePair<Key,Key>(remap.PhysicalKey, remap.MappedToKey));
        remaps = newremaps.ToDictionary(_ => _.Key, _ => _.Value);
    }

    public void AddOrUpdateMacro(KeyMacro macro){
        var newmacros = macros.Where(_ => _.Key != MacroKeyName(macro));
        newmacros = newmacros.Append(new KeyValuePair<string,KeyMacro>(MacroKeyName(macro),macro));
        macros = newmacros.ToDictionary(_ => _.Key, _ => _.Value);
    }
}