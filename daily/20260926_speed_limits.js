function speeding(speeds, limit) {
  const speeders = speeds.filter(speed => speed > limit);
  if (speeders.length === 0) return [0,0];
  return [
    speeders.length,
    speeders.reduce((sum, speed) => sum + speed - limit, 0) / speeders.length
  ];
}