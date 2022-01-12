

const mEC7Bearing = require("../ge_modules/mEC7_Bearing");

// const getAboutUsLink = require("./index");

// test("Returns about-us for english language", () => {
//     expect(getAboutUsLink("en-US")).toBe("/about-us");
// });

const d2_data1 = {
                length: 6,
                breadth: 2
}

const d2_resp1 = {
                length: 6,
                breadth: 2,
                qnc: 234.5678
}

test("Check D2", () => {
    expect(mEC7Bearing.calc_EC7_D2_data(d2_data1)).toBe(d2_resp1);
});