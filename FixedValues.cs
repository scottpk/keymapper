using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
static class TokenValueHelper{
    public static Dictionary<ActionToken, string> ActionTokenDictionary {
        get{
            Dictionary<ActionToken, string> d = new Dictionary<ActionToken, string>();
            d.Add(ActionToken.A,"A");
            d.Add(ActionToken.B,"B");
            d.Add(ActionToken.C,"C");
            d.Add(ActionToken.D,"D");
            d.Add(ActionToken.E,"E");
            d.Add(ActionToken.F,"F");
            d.Add(ActionToken.G,"G");
            d.Add(ActionToken.H,"H");
            d.Add(ActionToken.I,"I");
            d.Add(ActionToken.J,"J");
            d.Add(ActionToken.K,"K");
            d.Add(ActionToken.L,"L");
            d.Add(ActionToken.M,"M");
            d.Add(ActionToken.N,"N");
            d.Add(ActionToken.O,"O");
            d.Add(ActionToken.P,"P");
            d.Add(ActionToken.Q,"Q");
            d.Add(ActionToken.R,"R");
            d.Add(ActionToken.S,"S");
            d.Add(ActionToken.T,"T");
            d.Add(ActionToken.U,"U");
            d.Add(ActionToken.V,"V");
            d.Add(ActionToken.W,"W");
            d.Add(ActionToken.X,"X");
            d.Add(ActionToken.Y,"Y");
            d.Add(ActionToken.Z,"Z");
            d.Add(ActionToken.NUMBER1,"1");
            d.Add(ActionToken.NUMBER2,"2");
            d.Add(ActionToken.NUMBER3,"3");
            d.Add(ActionToken.NUMBER4,"4");
            d.Add(ActionToken.NUMBER5,"5");
            d.Add(ActionToken.NUMBER6,"6");
            d.Add(ActionToken.NUMBER7,"7");
            d.Add(ActionToken.NUMBER8,"8");
            d.Add(ActionToken.NUMBER9,"9");
            d.Add(ActionToken.NUMBER0,"0");
            d.Add(ActionToken.MINUS,"-");
            d.Add(ActionToken.EQUAL,"=");
            d.Add(ActionToken.F1,"F1");
            d.Add(ActionToken.F2,"F2");
            d.Add(ActionToken.F3,"F3");
            d.Add(ActionToken.F4,"F4");
            d.Add(ActionToken.F5,"F5");
            d.Add(ActionToken.F6,"F6");
            d.Add(ActionToken.F7,"F7");
            d.Add(ActionToken.F8,"F8");
            d.Add(ActionToken.F9,"F9");
            d.Add(ActionToken.F10,"F10");
            d.Add(ActionToken.F11,"F11");
            d.Add(ActionToken.F12,"F12");
            d.Add(ActionToken.F13,"F13");
            d.Add(ActionToken.F14,"F14");
            d.Add(ActionToken.F15,"F15");
            d.Add(ActionToken.F16,"F16");
            d.Add(ActionToken.F17,"F17");
            d.Add(ActionToken.F18,"F18");
            d.Add(ActionToken.F19,"F19");
            d.Add(ActionToken.F20,"F20");
            d.Add(ActionToken.F21,"F21");
            d.Add(ActionToken.F22,"F22");
            d.Add(ActionToken.F23,"F23");
            d.Add(ActionToken.F24,"F24");
            d.Add(ActionToken.LEFTSHIFT,"LSHFT");
            d.Add(ActionToken.RIGHTSHIFT,"RSHFT");
            d.Add(ActionToken.LEFTALT,"LALT");
            d.Add(ActionToken.RIGHTALT,"RALT");
            d.Add(ActionToken.LEFTWIN,"LWIN");
            d.Add(ActionToken.RIGHTWIN,"RWIN");
            d.Add(ActionToken.LEFTCONTROL,"LCTRL");
            d.Add(ActionToken.RIGHTCONTROL,"RCTRL");
            d.Add(ActionToken.HYPER,"HYPER");
            d.Add(ActionToken.MEH,"MEH");
            d.Add(ActionToken.OPENBRACKET,"OBRK");
            d.Add(ActionToken.CLOSEBRACKET,"CBRK");
            d.Add(ActionToken.PERIOD,"PER");
            d.Add(ActionToken.COMMA,"COM");
            d.Add(ActionToken.APOSTROPHE,"APOS");
            d.Add(ActionToken.TILDE,"TILDE");
            d.Add(ActionToken.FORWARDSLASH,"/");
            d.Add(ActionToken.BACKSLASH,"\\");
            d.Add(ActionToken.MUTE,"MUTE");
            d.Add(ActionToken.VOLUMEUP,"VOL+");
            d.Add(ActionToken.VOLUMEDOWN,"VOL-");
            d.Add(ActionToken.PLAY,"PLAY");
            d.Add(ActionToken.NEXT,"NEXT");
            d.Add(ActionToken.PREVIOUS,"PREV");
            d.Add(ActionToken.LEFTMOUSE,"LMOUS");
            d.Add(ActionToken.RIGHTMOUSE,"RMOUS");
            d.Add(ActionToken.MIDDLEMOUSE,"MMOUS");
            d.Add(ActionToken.MOUSE4,"MOUS4");
            d.Add(ActionToken.MOUSE5,"MOUS5");
            d.Add(ActionToken.ENTER,"ENT");
            d.Add(ActionToken.TAB,"TAB");
            d.Add(ActionToken.SPACE,"SPC");
            d.Add(ActionToken.DELETE,"DEL");
            d.Add(ActionToken.BACKSPACE,"BSPC");
            d.Add(ActionToken.HOME,"HOME");
            d.Add(ActionToken.END,"END");
            d.Add(ActionToken.PAGEUP,"PUP");
            d.Add(ActionToken.PAGEDOWN,"PDN");
            d.Add(ActionToken.LEFTARROW,"LFT");
            d.Add(ActionToken.RIGHTARROW,"RGHT");
            d.Add(ActionToken.UPARROW,"UP");
            d.Add(ActionToken.DOWNARROW,"DWN");
            d.Add(ActionToken.ESC,"ESC");
            d.Add(ActionToken.PRINT,"PRNT");
            d.Add(ActionToken.PAUSE,"PAUSE");
            d.Add(ActionToken.SCRLK,"SCRLK");
            d.Add(ActionToken.INSERT,"INS");
            d.Add(ActionToken.NUMLOCK,"NUMLK");
            d.Add(ActionToken.KP1,"KP1");
            d.Add(ActionToken.KP2,"KP2");
            d.Add(ActionToken.KP3,"KP3");
            d.Add(ActionToken.KP4,"KP4");
            d.Add(ActionToken.KP5,"KP5");
            d.Add(ActionToken.KP6,"KP6");
            d.Add(ActionToken.KP7,"KP7");
            d.Add(ActionToken.KP8,"KP8");
            d.Add(ActionToken.KP9,"KP9");
            d.Add(ActionToken.KP0,"KP0");
            d.Add(ActionToken.KPPLUS,"KP+");
            d.Add(ActionToken.KPMINUS,"KP-");
            d.Add(ActionToken.KPDIVIDE,"KP/");
            d.Add(ActionToken.KPMULTIPLY,"KP*");
            d.Add(ActionToken.KPENTER,"KPENT");
            d.Add(ActionToken.KPEQUAL,"KP=");
            d.Add(ActionToken.KPDECIMAL,"KP.");
            d.Add(ActionToken.CAPSLOCK,"CAPS");
            d.Add(ActionToken.FNTOGGLE,"FNTOG");
            d.Add(ActionToken.FNSHIFT,"FNSHF");
            d.Add(ActionToken.MENU,"MENU");
            d.Add(ActionToken.INTL,"INTL/");
            d.Add(ActionToken.CALC,"CALC");
            d.Add(ActionToken.SHUTDOWN,"SHTDN");
            d.Add(ActionToken.LED,"LED");
            d.Add(ActionToken.RANDOMDELAY,"DRAN");
            d.Add(ActionToken.NOACTION,"NULL");

            return d;
        }
    }
    public static Dictionary<PositionToken, string> PositionTokenDictionary = new Dictionary<PositionToken, string>(){
        [PositionToken.HK0] = "hk0",
        [PositionToken.HK1] = "hk1",
        [PositionToken.HK2] = "hk2",
        [PositionToken.HK3] = "hk3",
        [PositionToken.HK4] = "hk4",
        [PositionToken.HK5] = "hk5",
        [PositionToken.HK6] = "hk6",
        [PositionToken.HK7] = "hk7",
        [PositionToken.HK8] = "hk8",
        [PositionToken.HK9] = "hk9",
        [PositionToken.HK10] = "hk10",
        [PositionToken.ESCAPE] = "esc",
        [PositionToken.F1] = "f1",
        [PositionToken.F2] = "f2",
        [PositionToken.F3] = "f3",
        [PositionToken.F4] = "f4",
        [PositionToken.F5] = "f5",
        [PositionToken.F6] = "f6",
        [PositionToken.F7] = "f7",
        [PositionToken.F8] = "f8",
        [PositionToken.F9] = "f9",
        [PositionToken.F10] = "f10",
        [PositionToken.F11] = "f11",
        [PositionToken.F12] = "f12",
        [PositionToken.PRINT] = "prnt",
        [PositionToken.PAUSE] = "pause",
        [PositionToken.DELETE] = "del",
        [PositionToken.MUTE] = "mute",
        [PositionToken.VOLUMEDOWN] = "vol-",
        [PositionToken.VOLUMEUP] = "vol+",
        [PositionToken.PLAY] = "play",
        [PositionToken.PREVIOUS] = "prev",
        [PositionToken.NEXT] = "next",
        [PositionToken.INSERT] = "ins",
        [PositionToken.SCROLLLOCK] = "scrlk",
        [PositionToken.TILDE] = "tilde",
        [PositionToken.NUMBER1] = "1",
        [PositionToken.NUMBER2] = "2",
        [PositionToken.NUMBER3] = "3",
        [PositionToken.NUMBER4] = "4",
        [PositionToken.NUMBER5] = "5",
        [PositionToken.NUMBER6] = "6",
        [PositionToken.NUMBER7] = "7",
        [PositionToken.NUMBER8] = "8",
        [PositionToken.NUMBER9] = "9",
        [PositionToken.NUMBER0] = "0",
        [PositionToken.MINUS] = "-",
        [PositionToken.EQUALS] = "=",
        [PositionToken.BACKSPACE] = "bspc",
        [PositionToken.HOME] = "home",
        [PositionToken.TAB] = "tab",
        [PositionToken.Q] = "Q",
        [PositionToken.W] = "W",
        [PositionToken.E] = "E",
        [PositionToken.R] = "R",
        [PositionToken.T] = "T",
        [PositionToken.Y] = "Y",
        [PositionToken.U] = "U",
        [PositionToken.I] = "I",
        [PositionToken.O] = "O",
        [PositionToken.P] = "P",
        [PositionToken.OPENBRACKET] = "obrk",
        [PositionToken.CLOSEBRACKET] = "cbrk",
        [PositionToken.BACKSLASH] = "\\",
        [PositionToken.END] = "end",
        [PositionToken.CAPSLOCK] = "caps",
        [PositionToken.A] = "A",
        [PositionToken.S] = "S",
        [PositionToken.D] = "D",
        [PositionToken.F] = "F",
        [PositionToken.G] = "G",
        [PositionToken.H] = "H",
        [PositionToken.J] = "J",
        [PositionToken.K] = "K",
        [PositionToken.L] = "L",
        [PositionToken.COLON] = "colon",
        [PositionToken.APOSTROPHE] = "apos",
        [PositionToken.ENTER] = "ent",
        [PositionToken.PAGEUP] = "pup",
        [PositionToken.SHIFT] = "shft",
        [PositionToken.Z] = "z",
        [PositionToken.X] = "x",
        [PositionToken.C] = "c",
        [PositionToken.V] = "v",
        [PositionToken.B] = "b",
        [PositionToken.N] = "n",
        [PositionToken.M] = "m",
        [PositionToken.COMMA] = "com",
        [PositionToken.PERIOD] = "per",
        [PositionToken.FORWARDSLASH] = "/",
        [PositionToken.RIGHTSHIFT] = "rshft",
        [PositionToken.UPARROW] = "up",
        [PositionToken.PAGEDOWN] = "pdn",
        [PositionToken.LEFTCONTROL] = "lctrl",
        [PositionToken.LEFTWIN] = "lwin",
        [PositionToken.LEFTALT] = "lalt",
        [PositionToken.LEFTSPACE] = "lspc",
        [PositionToken.RIGHTSPACE] = "rspc",
        [PositionToken.RIGHTALT] = "ralt",
        [PositionToken.RIGHTCONTROL] = "rctrl",
        [PositionToken.LEFTARROW] = "lft",
        [PositionToken.DOWNARROW] = "dwn",
        [PositionToken.RIGHTARROW] = "rght"
    };
    public static string MacroDelayToken([Range(1,999)] int delay){
        return $"D{delay}";
    }
    public static string TapAndHoldDelayToken([Range(1,999)] int delay, PositionToken tap, PositionToken hold){
        return $"[{PositionTokenDictionary[tap]}][t&h{delay}][{hold}]";
    }
}
//each keyboard or mouse action supported has a unique "action" token that corresponds to a standard USB scan code
public enum ActionToken {
A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,
NUMBER1,NUMBER2,NUMBER3,NUMBER4,NUMBER5,NUMBER6,NUMBER7,NUMBER8,NUMBER9,NUMBER0,MINUS,EQUAL,
F1,F2,F3,F4,F5,F6,F7,F8,F9,F10,F11,F12,F13,F14,F15,F16,F17,F18,F19,F20,F21,F22,F23,F24,
LEFTSHIFT,RIGHTSHIFT,LEFTALT,RIGHTALT,LEFTWIN,RIGHTWIN,LEFTCONTROL,RIGHTCONTROL,HYPER,MEH,OPENBRACKET,CLOSEBRACKET,PERIOD,COMMA,APOSTROPHE,TILDE,FORWARDSLASH,BACKSLASH,
MUTE,VOLUMEUP,VOLUMEDOWN,PLAY,NEXT,PREVIOUS,LEFTMOUSE,RIGHTMOUSE,MIDDLEMOUSE,MOUSE4,MOUSE5,ENTER,TAB,SPACE,DELETE,BACKSPACE,HOME,END,PAGEUP,PAGEDOWN,LEFTARROW,
RIGHTARROW,UPARROW,DOWNARROW,ESC,PRINT,PAUSE,SCRLK,INSERT,NUMLOCK,KP1,KP2,KP3,KP4,KP5,KP6,KP7,KP8,KP9,KP0,KPPLUS,KPMINUS,KPDIVIDE,KPMULTIPLY,KPENTER,KPEQUAL,
KPDECIMAL,CAPSLOCK,FNTOGGLE,FNSHIFT,MENU,INTL,CALC,SHUTDOWN,LED,RANDOMDELAY,NOACTION
}

// each of the 95 keys on the keyboard has a unique "position" token to identify it
// for the 8 keys which have a unique embedded key action there is a unique Fn layer token which corresponds to it
public enum PositionToken {
    HK0,HK1,HK2,HK3,HK4,HK5,HK6,HK7,HK8,HK9,HK10,
    ESCAPE,F1,F2,F3,F4,F5,F6,F7,F8,F9,F10,F11,F12,PRINT,PAUSE,DELETE,
    MUTE,VOLUMEDOWN,VOLUMEUP,PLAY,PREVIOUS,NEXT,INSERT,SCROLLLOCK,
    TILDE,NUMBER1,NUMBER2,NUMBER3,NUMBER4,NUMBER5,NUMBER6,NUMBER7,NUMBER8,NUMBER9,NUMBER0,MINUS,EQUALS,BACKSPACE,HOME,
    TAB,Q,W,E,R,T,Y,U,I,O,P,OPENBRACKET,CLOSEBRACKET,BACKSLASH,END,
    CAPSLOCK,A,S,D,F,G,H,J,K,L,COLON,APOSTROPHE,ENTER,PAGEUP,
    SHIFT,Z,X,C,V,B,N,M,COMMA,PERIOD,FORWARDSLASH,RIGHTSHIFT,UPARROW,PAGEDOWN,
    LEFTCONTROL,LEFTWIN,LEFTALT,LEFTSPACE,RIGHTSPACE,RIGHTALT,RIGHTCONTROL,LEFTARROW,DOWNARROW,RIGHTARROW
}