using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class System_State : MonoBehaviour
{
    enum Key
    {
        none,
        db, // 사진의 1~9까지
        d,
        fd, 
        b,
        n, 
        f,
        ub,
        u,
        uf, 
        A, //약손
        B, //약발
        C, //강손
        D, //강발
        
    }
    enum State
    {
        Move,
        Attack,
        //아도겐은 펀치의 강,중,약에 따라 날아가는 속도가 달라짐
        strong_adogen, //강파동권
        weak_adogen, //약파동권

        breakingthecollarbone, //쇄골깨기
        pitofthestomach, //명치부수기
        oryugen, //승룡권
    
        //용권선풍각은 킥의 강,중 에 따라 거리가 달라짐
        strong_addaddaddugen, //강 용권선풍각
        weak_addaddaddugen, //약 용권선풍각
        air_addaddaddugen, //공중 용권선풍각
    }
    

    Key [] strong_adogen = {Key.d,Key.fd,Key.f,Key.C};
    Key [] weak_adogen = {Key.d,Key.fd,Key.f,Key.A};
    Key [] strong_addaddaddugen = {Key.d,Key.db,Key.b,Key.D};
    Key [] weak_addaddaddugen = {Key.d,Key.db,Key.b,Key.B};
    Key [] breakingthecollarbone = {Key.f,Key.A};
    Key [] pitofthestomach = {Key.f,Key.C};
    Key [] oryugen = {Key.f,Key.d,Key.fd,Key.C};
    Key [] strong_sinkuadogen = {Key.d,Key.fd,Key.f,Key.d,Key.fd,Key.f,Key.C};
    Key [] weaks_sinkuadogen = {Key.d,Key.fd,Key.f,Key.d,Key.fd,Key.f,Key.A};

}
