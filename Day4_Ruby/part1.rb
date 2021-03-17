#!/usr/bin/env ruby

require 'digest'

SECRET_KEY = "iwrupvqb"

# Find MD5 hash which starts with at least 5 zeros
def mine(key)

  number = 0

  while true
    hash = Digest::MD5.hexdigest("#{key}#{number}")
    return number if hash =~ /\A00000/
    number += 1
  end
end

puts mine(SECRET_KEY)