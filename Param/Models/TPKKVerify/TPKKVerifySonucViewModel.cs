﻿using TurkPosWSTEST;
using Param.DTOs.TP_KK_Verify;

namespace Param.Models.TPKKVerify
{
    public class TPKKVerifySonucViewModel
    {
        public ST_TP_Islem_Odeme? Sonuc { get; set; }
        public TP_KK_VerifyPostDTO? SonucPost { get; set; }
    }
}