﻿using TurkPosWS;
using ParamPos.DTOs.TP_KK_Verify;

namespace ParamPos.Models.TPKKVerify
{
    public class TPKKVerifySonucViewModel
    {
        public ST_TP_Islem_Odeme? Sonuc { get; set; }
        public TP_KK_VerifyPostDTO? SonucPost { get; set; }
    }
}