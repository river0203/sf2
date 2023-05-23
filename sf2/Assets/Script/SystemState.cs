using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemState : MonoBehaviour
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
    enum status
    {
        Move,
        Attack,
        //아도겐은 펀치의 강,중,약에 따라 날아가는 속도가 달라짐
        strongadogen, //강파동권
        middleadogen, //중파동권
        weakadogen, //약파동권

        strongpiggybacking, //강 업어치기
        middlepiggybacking, //중 업어치기
        strongbackanfdlipping, //강 배대뒤치기
        middlebackanfdlipping, //중 배대뒤치기
        breakingthecollarbone, //쇄골깨기
        pitofthestomach, //명치부수기
        oryugen, //승룡권
        //용권선풍각은 킥의 강,중 에 따라 거리가 달라짐
        strongaddaddaddugen, //강용권선풍각
        middleaddaddaddugen, //중용권선풍각
        weakaddaddaddugen, //약용권선풍각
        airaddaddaddugen, //공중 용권선풍각
    }

    Key [] strong_adogen = {Key.d,Key.fd,Key.f,Key.C};
    Key [] weak_adogen = {Key.d,Key.fd,Key.f,Key.A};
    Key [] strong_addaddaddugen = {Key.d,Key.db,Key.b,Key.D};
    Key [] weak_addaddaddugen = {Key.d,Key.db,Key.b,Key.B};
    Key [] left_strong_piggybacking = {Key.b,Key.C};
    Key [] right_strong_piggybacking = {Key.f,Key.C};
    Key [] left_weak_piggybacking = {Key.b,Key.A};
    Key [] right_middle_piggybacking = {Key.f,Key.A};
    Key [] left_strong_backandflipping = {Key.b,Key.D};
    Key [] right_strong_backandflipping = {Key.f,Key.D};
    Key [] left_weak_backanfdlipping = {Key.b,Key.B};
    Key [] right_weak_backanflipping = {Key.f,Key.B};
    Key [] breakingthecollarbone = {Key.f,Key.A};
    Key [] pitofthestomach = {Key.f,Key.C};
    Key [] oryugen = {Key.f,Key.d,Key.fd,Key.C};
    Key [] weak_oryugen = {Key.f,Key.d,Key.fd,Key.A};
    Key [] strong_sinkuadogen = {Key.d,Key.fd,Key.f,Key.d,Key.fd,Key.f,Key.C};
    Key [] weaks_sinkuadogen = {Key.d,Key.fd,Key.f,Key.d,Key.fd,Key.f,Key.A};
}
