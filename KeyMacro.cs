using System.ComponentModel.DataAnnotations;
class KeyMacro {
    [Required]
    public Key TriggerKey {get;set;}
    public Key CoTrigger {get;set;} = null;
    [System.ComponentModel.DataAnnotations.Range(0,9)]
    public int IndividualPlaybackSpeed{get;set;} = 5;
}