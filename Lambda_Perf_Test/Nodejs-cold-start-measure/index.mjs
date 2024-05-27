export const handler = async (event) => {
  // TODO implement
  const inputParam = parseInt(event.inputParam) || 0;
  const unixEpochTime = Math.floor(new Date().getTime());

  // Calculate the difference
  const timeDifference = unixEpochTime - inputParam;
  
  console.log("Difference: " + timeDifference)  
  const response = {
    statusCode: 200,
    body: `The difference between Unix Epoch time and inputParam is: ${timeDifference}`,
  };
  return response;
};
