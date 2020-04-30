
export default function test() {
    console.log('I am exported')
    const repArr = [1, 1, 1, 12, 2, 23, 3, 3, 44, 9, 5, 6, 7, 8];
    const result = [...new Set(repArr)]
    return (result);
}
