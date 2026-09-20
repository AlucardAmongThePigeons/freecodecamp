/*
 F *ile Storage

 Given a file size, a unit for the file size, and hard drive capacity in gigabytes (GB), return the number of files the hard drive can store using the following constraints:

 The unit for the file size can be bytes ("B"), kilobytes ("KB"), or megabytes ("MB").
 Return the number of whole files the drive can fit.
 Use the following conversions:

 Unit 	Equivalent
 1 B 	1 B
 1 KB 	1000 B
 1 MB 	1000 KB
 1 GB 	1000 MB

 For example, given 500, "KB", and 1 as arguments, determine how many 500 KB files can fit on a 1 GB hard drive.
 */

const UNIT_LOOKUP = Object.freeze({
    "B": 1,
    "KB": 1000,
    "MB": 1000000,
    "GB": 1000000000,
});

function numberOfFiles(fileSize, fileUnit, driveSizeGb) {
    const fileSizeBytes = fileSize * UNIT_LOOKUP[fileUnit];
    const driveSizeBytes = driveSizeGb * UNIT_LOOKUP["GB"];

    const n = Math.floor(driveSizeBytes / fileSizeBytes);

    return n;
}
