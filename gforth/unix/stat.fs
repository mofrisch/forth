begin-structure file-stat
  drop 0 4 +field st_dev
  drop 8 8 +field st_ino
  drop 4 2 +field st_mode
  drop 16 4 +field st_uid
  drop 20 4 +field st_gid
  drop 24 4 +field st_rdev
  drop 96 8 +field st_size
  drop 112 4 +field st_blksize
  drop 104 8 +field st_blocks
  drop 32 16 +field st_atime
  drop 48 16 +field st_mtime
  drop 64 16 +field st_ctime
drop 144 end-structure
