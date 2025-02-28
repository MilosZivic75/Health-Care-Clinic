﻿using Hospital.Mapper;
using Hospital.Rooms_and_equipment.Model;
using Hospital.Rooms_and_equipment.Repository;
using Hospital.Rooms_and_equipment.Service;
using Hospital_API.Adapter;
using Hospital_API.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private  readonly IRoomService roomService;
        public RoomController(IRoomService roomService)
        {
            this.roomService = roomService;
        }

        [HttpPost("addRoom")]
        public IActionResult AddRoom(Room room)
        {
            roomService.Add(room);
            return Ok();
        }

        [HttpGet("getRoomsByFloorId/{id?}")]
        public IActionResult GetRoomsByFloorId(int id)
        {
            List<RoomDTO> allRooms = new List<RoomDTO>();
            roomService.GetRoomsByFloorId(id).ForEach(Room
                => allRooms.Add(RoomAdapter.RoomToRoomDTO(Room)));
            return Ok(allRooms);
        }

        [HttpGet("isFirstRoomNextToSecond/{id1}/{id2}")]
        public Boolean IsFirstRoomNextToSecond(int id1, int id2) {
            List<RoomDTO> rooms = new List<RoomDTO>();
            roomService.GetAll().ToList().ForEach(Room
                => rooms.Add(RoomAdapter.RoomToRoomDTO(Room)));
            RoomDTO room1 = new RoomDTO();
            RoomDTO room2 = new RoomDTO();

            foreach (RoomDTO room in rooms) {
                if (room.Id == id1)
                    room1 = room;
                else if (room.Id == id2)
                    room2 = room;
            }

            return roomService.checkRooms(RoomAdapter.RoomDTOToRoom(room1), RoomAdapter.RoomDTOToRoom(room2));
        }


        [HttpGet("getRoomById/{id?}")]
        public IActionResult GetRoomById(int id)
        {
            return Ok(RoomAdapter.RoomToRoomDTO(roomService.GetOneById(id)));
        }

        [HttpGet("getRooms")]
        public IActionResult GetRooms()
        {
            List<RoomDTO> allRooms = new List<RoomDTO>();
            roomService.GetAll().ToList().ForEach(Room
                => allRooms.Add(RoomAdapter.RoomToRoomDTO(Room)));
            return Ok(allRooms);
        }

        [HttpGet("getSearchedRooms/{searchText?}")]
        public IActionResult GetSearchedRooms(String searchText)
        {
            List<RoomDTO> result = new List<RoomDTO>();
            if (searchText != null)
                roomService.GetSearchedRooms(searchText).ForEach(room
                    => result.Add(RoomAdapter.RoomToRoomDTO(room)));
            return Ok(result);
        }
    }

}
