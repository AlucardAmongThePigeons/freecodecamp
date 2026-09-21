const UNIT_TO_BYTES = Object.freeze({
  "B": 1,
  "KB": 1e3,
  "MB": 1e6,
  "GB": 1e9,
  "TB": 1e12
});

function toBytes(size, unit) {
  return size * UNIT_TO_BYTES[unit];
}

function numberOfVideos(videoSize, videoUnit, driveSize, driveUnit) {
  const VIDEO_UNITS = ["B", "KB", "MB", "GB"];
  const DRIVE_UNITS = ["GB", "TB"];

  if (!VIDEO_UNITS.includes(videoUnit)) return "Invalid video unit";
  if (!DRIVE_UNITS.includes(driveUnit)) return "Invalid drive unit";

  const videoBytes = toBytes(videoSize, videoUnit);
  const driveBytes = toBytes(driveSize, driveUnit);

   return Math.floor(driveBytes / videoBytes);
}
