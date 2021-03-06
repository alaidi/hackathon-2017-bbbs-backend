﻿using AspNetCoreWebService.DTOs;
using AspNetCoreWebService.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspNetCoreWebService.Controllers
{
    [Route("api/[controller]")]
    public class UserMappingController
    {
        [HttpPost]
        [Route("CreateLittleParentMap")]
        public LittleParentMapModel CreateLittleParentMap([FromBody] LittleParentMapModel inputModel)
        {
            return UserMappingService.CreateLittleParentMap(inputModel);
        }

        [HttpPost]
        [Route("CreateBigLittleParentMap")]
        public BigLittleParentMapModel CreateBigLittleParentMap([FromBody] BigLittleParentMapModel inputModel)
        {
            return UserMappingService.CreateBigLittleParentMap(inputModel);
        }

        [HttpGet]
        [Route("FindUnmatchedBigs")]
        public List<UserAccountModel> FindUnmatchedBigs()
        {
            return UserMappingService.FindUnmatchedBigs();
        }

        [HttpGet]
        [Route("FindUnmatchedLittles")]
        public List<UserAccountModel> FindUnmatchedLittles()
        {
            return UserMappingService.FindUnmatchedLittles();
        }

        [HttpGet]
        [Route("FindParentForLittle/{littleId}")]
        public ConsolidatedUserInformationResponseModel FindParentForLittle(int littleId)
        {
            return UserMappingService.FindParentForLittle(littleId);
        }

        [HttpGet]
        [Route("GetMatch/{matchId}")]
        public MatchedBigLittleParentModel GetMatch(int matchId)
        {
            return UserMappingService.GetMatch(matchId);
        }

        [HttpGet]
        [Route("GetAllMatches")]
        public List<MatchedBigLittleParentModel> GetAllMatches()
        {
            return UserMappingService.GetAllMatches();
        }

        [Route("GetAllMatchesShallow")]
        public List<ShallowMatchedBigLittleParentModel> GetAllMatchesShallow()
        {
            return UserMappingService.GetAllMatchesShallow();
        }

        [HttpGet]
        [Route("GetMatchByUserAccountId/{userId}")]
        public MatchedBigLittleParentModel GetMatchByUserAccountId(int userId)
        {
            var ret = UserMappingService.GetMatchByUserAccountId(userId);

            if (ret != null)
                return ret;
            return null;
        }

        [HttpGet]
        [Route("DeleteMatchById/{matchId}")]
        public void DeleteMatchById(int matchId)
        {
            UserMappingService.DeleteMatchById(matchId);
        }
    }
}
