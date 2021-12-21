using System.ComponentModel.DataAnnotations;

class Key {
    public string KeyName {get; }
    public PositionToken PositionToken {get;}
    public Key(string name, PositionToken positionToken){
        KeyName = name;
        PositionToken = positionToken;
    }
}